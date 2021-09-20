using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RehabusSystem.Common.DbContexts;
using Microsoft.Extensions.Configuration;
using DemoThreeLayers.Repository.Interfaces;
using DemoThreeLayers.Repository;
using DemoThreeLayers.Services.Interfaces;
using DemoThreeLayers.Services;

namespace DemoThreeLayers
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // DependencyInjection
        public void ConfigureServices(IServiceCollection services)
        {
            // 註冊 EF Core
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            // 註冊 MVC
            services.AddMvc();

            // 註冊 Repository
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            // 註冊 Service
            services.AddTransient<IEmployeeService, EmployeeService>();

            // 註冊 AutoMapper
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
