using EA.DataAccess.Data;
using EA.DataAccess.Repositories;
using EA.Services;
using EA.Services.MappingProfile;
using EA.WebAPI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

namespace EA.WebAPI
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
            //uygulama icinde ihtiyac duyulacak tum nesneler veya yapılandırmalar burada eklenir.

            services.AddControllers();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            var connectionString = Configuration.GetConnectionString("db");
            services.AddDbContext<EADbContext>(option =>
            {
                option.UseSqlServer(connectionString);
                option.LogTo(Console.WriteLine);
            });
            services.AddAutoMapper(typeof(MapProfile));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EA.WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.UseWelcomePage();
           // app.Run(async (context) =>
           //{
           //    await context.Response.WriteAsync("Deneme");
           //});
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EA.WebAPI v1"));
            }


            app.UseMiddleware<CustomMiddleware>();
            //app.UseMiddleware<>
            app.UseHttpsRedirection();
            //app.UseBadWordFilter();
            app.UseRouting();



            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
