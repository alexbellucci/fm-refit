using FMR.BLL.Services;
using FMR.DAL.Autenticacao;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Net.Http;

namespace FMR.BLL
{
    public static class ConfiguracaoDeInicializacao
    {
        public static void InjetarClients(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<DicionarioAuthHandler>();

            serviceCollection.AddSingleton(serviceProvider =>
                                   RestService
                                       .For<IAnimeClient>("https://animechan.vercel.app/api"));

            serviceCollection.AddSingleton(serviceProvider =>
                                               RestService
                                                   .For<IDicionarioClient
                                                   >(new HttpClient(serviceProvider.GetService<DicionarioAuthHandler>())
                                                   {
                                                       BaseAddress =
                                                           new Uri("https://od-api.oxforddictionaries.com/api")
                                                   }));
        }
     }
}
