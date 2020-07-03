using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NHibernate;
using IOC;
using Aplicacao.Cursos.Servicos.Interfaces;
using Aplicacao.Cursos.Profiles;
using Infra.Cursos.Repositorios;
using Dominio.Cursos.Servicos;
using Aplicacao.Trilhas.Servicos.Interfaces;
using Dominio.Trilhas.Repositorios;
using Dominio.Trilhas.Servicos.Interfaces;
using Aplicacao.Trilhas.Servicos;
using Infra.Trilhas.Repositorios;
using Dominio.Trilhas.Servicos;
using Aplicacao.Trilhas.Profiles;

namespace Api
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

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title= "API Interdisciplinar", Version = "v1" });
            });
            ISessionFactory _sessionFactory = ServiceHelper.CreateSessionFactory("Server=127.0.0.1;User Id=root; Password=jota1234;");
            services.AddSingleton(_sessionFactory);
            services.AddScoped(factory =>
            {
                return _sessionFactory.OpenSession();
            });
            services.AddAutoMapper(typeof(TrilhaProfile).GetTypeInfo().Assembly);
            services.Scan(scan => scan.FromAssembliesOf(typeof(TrilhasAppServico)).AddClasses().AsImplementedInterfaces().WithScopedLifetime());
            services.Scan(scan => scan.FromAssembliesOf(typeof(TrilhasRepositorio)).AddClasses().AsImplementedInterfaces().WithScopedLifetime());
            services.Scan(scan => scan.FromAssembliesOf(typeof(TrilhasServico)).AddClasses().AsImplementedInterfaces().WithScopedLifetime());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                x.RoutePrefix = string.Empty;
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
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
