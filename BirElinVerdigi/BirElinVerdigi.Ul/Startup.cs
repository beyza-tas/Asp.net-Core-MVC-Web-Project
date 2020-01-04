using BirElinVerdigi.Business.Abstract;
using BirElinVerdigi.Business.Concrete;
using BirElinVerdigi.DataAccess.Abstract;
using BirElinVerdigi.DataAccess.Concrete.EntityFramework;
using BirElinVerdigi.Ul.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BirElinVerdigi.Ul
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Itbl_kategoriService, tbl_kategoriManeger>();
            services.AddScoped<Itbl_kategoriDal, Eftbl_kategoriDal>();
            services.AddScoped<Itbl_ilanService, tbl_ilanManeger>();
            services.AddScoped<Itbl_ilanDal, Eftbl_ilanDal>();
            services.AddScoped<Itbl_uyelerService, tbl_uyelerManeger>();
            services.AddScoped<Itbl_uyelerDal, Eftbl_uyelerDal>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<LoginFilter>();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.HttpOnly = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}
