using CrudSquadra.Adapter;
using CrudSquadra.Bordas.Adapter;
using CrudSquadra.Bordas.Repositorios;
using CrudSquadra.Context;
using CrudSquadra.Repositorios;
using CrudSquadra.Services;
using CrudSquadra.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra
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

            //Alertando o Banco de dados
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlSquadra")));

            //Adicionando os servicos
            services.AddScoped<ICarroService, CarroService>();

            services.AddScoped<IAdicionarCarroUseCase, AdicionarCarroUseCase>();
            services.AddScoped<IAtualizarCarroUseCase, AtualizarCarroUseCase>();
            services.AddScoped<IRemoverCarroUseCase, RemoverCarroUseCase>();
            services.AddScoped<IRetornarCarroPorIdUseCase, RetornarCarroPorIdUseCase>();
            services.AddScoped<IRetornarListaDeCarroUseCase, RetornarListaDeCarroUseCase>();
            
            services.AddScoped<IRepositorioCarros, RepositorioCarros>();
            services.AddScoped<IAdicionarCarroAdapter, AdicionarCarroAdapter>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CrudSquadra", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CrudSquadra v1"));
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
