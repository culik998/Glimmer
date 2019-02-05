using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.HttpsPolicy;
using Glimmer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace Glimmer
{
    public class Startup
    {
        public IConfiguration Configuration { get;private set; }

        public Startup(IConfiguration configuration)
        {
            configuration = Configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpsRedirection(x =>
            {
                x.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                x.HttpsPort = 12000;
           
            });

            services.AddDbContext<GlimmerDbContext>(x =>
            {

                x.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);

            });
            services.AddMvc();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            env.EnvironmentName = EnvironmentName.Production;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); 


            
            app.UseMvcWithDefaultRoute();
        }
    }
}
