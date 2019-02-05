using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CardGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace CardGenerator
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }

        public CardDbContext dbContext { get; set; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CardDbContext>(x =>
            {

                x.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);

            });

            services.AddMvc();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
             
            }
           
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
