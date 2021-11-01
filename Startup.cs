using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncidenciasMixtas.Contexts;
using Microsoft.EntityFrameworkCore;
using IncidenciasMixtas.Utilidades;

namespace IncidenciasMixtas
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
            services.AddDbContext<EmpleadosContext>(options => options.UseSqlServer(Configuration.GetConnectionString("consumidor")));
            services.AddDbContext<puenteContext>(options => options.UseSqlServer(Configuration.GetConnectionString("puente")));
            services.AddDbContext<Otc_BioContexts>(options => options.UseSqlServer(Configuration.GetConnectionString("Otc_BIO")));
            services.AddDbContext<ice_BioContexts>(options => options.UseSqlServer(Configuration.GetConnectionString("ice_BIO")));
            services.AddDbContext<Ntc_BioContexts>(options => options.UseSqlServer(Configuration.GetConnectionString("NTC_BIO")));
            services.AddDbContext<Shelter_BioContexts>(options => options.UseSqlServer(Configuration.GetConnectionString("shelter_BIO")));
           
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
