﻿using ERPQuala.BAL.DashboardBAL;
using ERPQuala.BAL.ProviderBAL;
using ERPQuala.BAL.StockBAL;
using ERPQuala.BAL.StockBL;
using ERPQuala.BAL.UserBAL;
using ERPQuala.Crosscutting.Model;
using ERPQuala.DAL.Dashboard.Repository;
using ERPQuala.DAL.Provider.Repository;
using ERPQuala.DAL.Stock.Repository;
using ERPQuala.DAL.User.Reposiroty;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace ERPQualaApi
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
            services.AddDbContext<WebAPIDataContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("Database")));
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "ERPService",
                    Description = "My First ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Talking Dotnet", Email = "contact@talkingdotnet.com", Url = "www.talkingdotnet.com" }
                });
            });

            services.AddScoped<IStockBl,StockBl>();
            services.AddScoped<IUserBl, UserBl>();
            services.AddScoped<IProviderBl, ProviderBl>();
            services.AddScoped<IDashboardBl, DashboardBl>();

            services.AddScoped<IStockDal, StockDal>();
            services.AddScoped<IUserDal, UserDal>();
            services.AddScoped<IProviderDal, ProviderDal>();
            services.AddScoped<IDashboardDal, DashboardDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }

    }
}
