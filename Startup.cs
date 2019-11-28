using FSL.AppSettingsAspNetCore.Extensions;
using FSL.AppSettingsAspNetCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace FSL.AppSettingsAspNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(
            IServiceCollection services)
        {
            // Way 5
            services.Configure<MySettingsConfiguration>(Configuration.GetSection("MySettings"));

            //// Way 6
            //var mySettings = new MySettingsConfiguration();
            //new ConfigureFromConfigurationOptions<MySettingsConfiguration>(Configuration.GetSection("MySettings")).Configure(mySettings);
            //services.AddSingleton(mySettings);

            // Way 6 extesion
            services.AddConfiguration<MySettingsConfiguration>(Configuration, "MySettings");

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
