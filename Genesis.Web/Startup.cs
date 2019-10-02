using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Genesis.Data;
using Genesis.Data.Repositories;
using Genesis.Data.UnitOfWork;
using Genesis.Data.Repositories.Interfaces;
using Genesis.Service.Contacts.Services.Interfaces;
using Genesis.Service.Contacts.Services;
using Genesis.Service.Contacts;
using Genesis.Service.Entreprises.Services.Interfaces;
using Genesis.Service.Entreprises.Services;
using Genesis.Service.Entreprises;


namespace Genesis.Web
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
            
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(
                    options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
            var connection = @"Server=(localdb)\mssqllocaldb;Database=GenesisProject;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<GenesisContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IEntrepriseRepository, EntrepriseRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IEntrepriseService, EntrepriseService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
