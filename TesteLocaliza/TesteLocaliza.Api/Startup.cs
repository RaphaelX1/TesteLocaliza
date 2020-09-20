using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TesteLocaliza.Interfaces;
using TesteLocaliza.Servicos;

namespace TesteLocaliza.Api
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
            InstanciarSwaggerGen(services);
            InstanciarInjecaoDependenciaServicos(services);
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

            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteLocaliza.Api");
            });
        }

        public void InstanciarSwaggerGen(IServiceCollection services)
        {
            // Swagger
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "TesteLocaliza.Api",
                        Version = GetType().Assembly.GetName().Version.ToString(),
                        Description = "Projeto teste localiza",
                        Contact = new OpenApiContact
                        {
                            Name = "Raphael Martins"
                            
                        }
                    });
            });
        }

        public void InstanciarInjecaoDependenciaServicos(IServiceCollection services)
        {
            services.AddTransient<IDecompositorServico, DecompositorServico>();
            services.AddTransient<IDivisoresServico, DivisoresServico>();
            services.AddTransient<INumerosPrimosServico, NumerosPrimosServico>();
        }
    }
}
