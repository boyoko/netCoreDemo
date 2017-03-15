using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Angular2.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            // support cors
            #region 跨域
            //var urls = Configuration["AppConfig:Cores"].Split(',');
            //var urls = "http://localhost:5000/";
            var urls = new List<string>
            {
                "http://192.168.1.113:4200/",
                "http://192.168.1.113:5000/",
                "http://192.168.1.109:4200",
                "http://192.168.1.109:5000"
            }; 
            //urls += ",http://192.168.1.109:4200";
            //urls += ",http://192.168.1.109:5000";
            services.AddCors(options =>
            options.AddPolicy("AllowSameDomain",builder => builder.WithOrigins(urls.ToArray())
                                                                    .AllowAnyMethod()
                                                                    .AllowAnyHeader()
                                                                    .AllowAnyOrigin()
                                                                    .AllowCredentials())
            );
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            
            // support cors
            app.UseCors("AllowSameDomain");
        }
    }
}
