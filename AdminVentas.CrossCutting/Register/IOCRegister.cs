using AdminVentas.Application.Contracts.Services;
using AdminVentas.Application.Services;
using AdminVentas.DataAccess.Contracts.Repositories;
using AdminVentas.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminVentas.CrossCutting.Register
{
    public static class IOCRegister
    {
        public static IServiceCollection AddRegistration(IServiceCollection dependence)
        {
            AddRegisterRepositories(dependence);

            return dependence;
        }

        /// <summary>
        /// Método que agrega los servicios creados para exponerlos como contratos
        /// </summary>
        /// <param name="services">Servicio a inyectar</param>
        /// <returns>Devuelve los servicios</returns>
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            //services.AddTransient<IUserService, UserService>();

            return services;
        }

        /// <summary>
        /// Método que registra los repositorios creados para exportarlos como Inyección de Dependencias
        /// </summary>
        /// <param name="services">Repositorio a inyectar</param>
        /// <returns>Devuelve los repositorios</returns>
        private static IServiceCollection AddRegisterRepositories(IServiceCollection repositories)
        {
            repositories.AddTransient<IUserRepository, UserRepository>();

            return repositories;
        }
    }
}
