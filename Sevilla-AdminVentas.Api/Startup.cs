using AdminVentas.CrossCutting.Register;
using AdminVentas.DataAccess;
using AdminVentas.DataAccess.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sevilla_AdminVentas.Api.Config;

namespace Sevilla_AdminVentas.Api
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
            services.AddTransient<IBDGestorVentasContext, BDGestorVentasContext>();
            IOCRegister.AddRegistration(services);

            //Se obtiene la connection string que apunta a la DB
            string connectionString = Configuration.GetConnectionString("DataBaseConnection");
            services.AddDbContext<BDGestorVentasContext>(options => 
            options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Sevilla-AdminVentas.Api")));

            //Registro de servicios
            IOCRegister.AddRegistration(services);
            SwaggerConfig.AddRegistration(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerConfig.AddRegistration(app);
            app.UseMvc();
        }
    }
}
