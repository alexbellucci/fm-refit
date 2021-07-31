using FMR.BLL;
using FMR.BLL.Injections;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace FMR.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(options => { options.EnableAnnotations(); });

            BllServicesDi.Config(services);
            services.InjetarClients();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            string basePath = Environment.GetEnvironmentVariable("VIRTUAL_PATH") ?? "";

            app.UseSwagger(c =>
            {
                c.RouteTemplate = "swagger/{documentName}/swagger.json";
                c.PreSerializeFilters.Add((swagger, request) =>
                                              swagger.Servers = new List<OpenApiServer>
                                              {
                                                                 new OpenApiServer
                                                                 {
                                                                     Url = $"https://{request.Host.Value}{basePath}"
                                                                 }
                                              });
            });


            app.UseSwaggerUI(swaggerOptions =>
                            {
                                swaggerOptions.SwaggerEndpoint($"{basePath}/swagger/v1/swagger.json",
                                                    "Flash Meeting Refit V1");
                                swaggerOptions.RoutePrefix = string.Empty;
                            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
