using FMR.DL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FMR.BLL.Injections
{
    // Classe de injeção de services 
    public static class BllServicesDi
    {
        public static void Config(IServiceCollection servicesContainer)
        {

            // Pegando todos os tipos que temos declarados nesse pacote de BLL
            IEnumerable<Type> allTypes = typeof(BllServicesDi)
                                         .GetTypeInfo()
                                         .Assembly
                                         .GetTypes();

            // Pegando todos os services
            IEnumerable<Type> services = allTypes.Where(type =>
                                                            type.GetInterfaces()
                                                                .Contains(typeof(IDependencyInjectionService)) &&
                                                            !type.IsAbstract &&
                                                            !type.IsInterface
                                                       );

            // Para cada um deles adicionar no container de injeção de dependencias
            foreach (Type service in services)
            {
                // Get all interfaces of the service
                IEnumerable<Type> interfaces = service.GetInterfaces();

                // Iterate each interface of implemented type
                foreach (var item in interfaces) servicesContainer.AddTransient(item, service);
            }
        }
    }
}