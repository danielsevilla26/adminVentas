using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sevilla_AdminVentas.Api.Config
{
    public class SwaggerConfig
    {
        /// <summary>
        /// Método que se encarga de configurar los servicios
        /// </summary>
        /// <param name="services">Servicio a configurar</param>
        /// <returns>Devuelve el servicio configurado</returns>
        public static IServiceCollection AddRegistration(IServiceCollection services)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;//Ruta donde se encuentra alojada la aplicación
            var xmlPath = Path.Combine(basePath, "GestorVentas.Api.xml");//Ruta donde se encuentra el XML que genera el proyecto

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "GestorVentas API v1", Version = "v1" });
                c.IncludeXmlComments(xmlPath);
            }
            );

            return services;
        }


        public static IApplicationBuilder AddRegistration(IApplicationBuilder app)
        {
            app.UseSwagger();
            //Se añade el endpoint de swagger.json
            app.UseSwaggerUI( c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GestorVentas API v1"));

            return app;
        }
    }
}
