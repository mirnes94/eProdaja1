using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Filters;
using eProdaja.WebAPI.Security;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using System.Web.Http;
using System.Reflection;

namespace eProdaja.WebAPI
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
                services.AddMvc(x => x.Filters.Add<ErrorFilter>());

                services.AddControllers();

                services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
               
                
            });

               services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

                services.AddScoped<ICRUDService<Model.Proizvod, ProizvodSearchRequest, ProizvodInsertUpdateRequest, ProizvodInsertUpdateRequest>, ProizvodService>();
                services.AddScoped<IKorisniciService, KorisniciService>();

                services.AddScoped<IService<VrsteProizvodaModel, object>, BaseService<VrsteProizvodaModel, object, VrsteProizvoda>>();
                services.AddScoped<IService<JediniceMjereModel, object>, BaseService<JediniceMjereModel, object, JediniceMjere>>();
                services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            // services.AddScoped<IProizvodService, ProizvodService>();
            // services.AddScoped<IJediniceMjereService, JediniceMjereService>();
            // services.AddScoped<IVrsteProizvodaService, VrsteProizvodaService>();

            var connection = @"Server=.;Database=eProdaja;Trusted_Connection=True;ConnectRetryCount=0";
                services.AddDbContext<eProdajaContext>(options => options.UseSqlServer(connection));
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseAuthentication();

                //app.UseHttpsRedirection(); da nas .net core automatski prebaci na Https

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });

                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();

                // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
                // specifying the Swagger JSON endpoint.
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
            }
        }
    }

