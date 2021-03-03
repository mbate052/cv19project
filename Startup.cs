using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv19project.Model;
using cv19project.services;
using cv19project.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace cv19project
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
            services.Configure<ProvinceDatabaseSettings>(
                Configuration.GetSection(nameof(ProvinceDatabaseSettings)));

            services.AddSingleton<ProvinceDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ProvinceDatabaseSettings>>().Value);

            services.AddRazorPages();
            services.AddTransient<JsonProvinceReaderService>();
            services.AddSingleton<ProvincesService>();

        }

        private void NewMethod(IServiceCollection services)
        {
            services.Configure<ProvinceDatabaseSettings>(
                Configuration.GetSection(nameof(ProvinceDatabaseSettings)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}