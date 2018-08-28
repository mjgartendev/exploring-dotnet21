using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
// Add Dependencies for Swagger API Docs
using TodoApi.Models;
using NJsonSchema;
using NSwag.AspNetCore;
using System.Reflection;

namespace TodoApi
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
        // Register the DbContext to use a database service          
            // Use Azure Connection if Production env
            // otherwise use LocalDb connection for development
                // Note: This can be done much more elegantly using appSettings.{environment}.json files, 
                // but this example is easier to see what's happening
            if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                services.AddDbContext<TodoContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("AzureSqlConnection")));
            else
                services.AddDbContext<TodoContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("LocalDbConnection")));
            
            // services.AddDefaultIdentity<IdentityUser>()
            //                 .AddEntityFrameworkStores<TodoContext>();
                        
            // Add application services.
            //services.AddTransient<IEmailSender, EmailSender>();

            // SetCompatabilityVersion required to use ApiController + ControllerBase
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // HTTP Strict Transfer Security
                app.UseHsts();
            }

            // Enable the Swagger UI middleware and the Swagger generator
            app.UseSwaggerUi(typeof(Startup).GetTypeInfo().Assembly, settings =>
            {
                settings.GeneratorSettings.DefaultPropertyNameHandling =
                    PropertyNameHandling.CamelCase;
            });

            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Todo", action = "Get" });
            });

        }
    }
}
