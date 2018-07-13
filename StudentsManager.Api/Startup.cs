using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Converters;
using StudentManager.Domain.Interfaces.Repositories;
using StudentsManager.DataMongo;
using StudentsManager.DataMongo.Context;
using StudentsManager.DataMongo.Repositories;
using System;
using System.IO;

namespace StudentsManager.Api
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
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddTransient<DbInitializer>();            
            services.AddTransient<StudentsManagerContext>();           


            //###Sql Only/###
            //services.AddDbContext<StudentsManagerContext>(options =>
            //      options.UseSqlServer(Configuration.GetConnectionString("StudentsManagerContext")));

            // Add framework services.

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            //###Sql Only/###
            // put param  StudentsManagerContext context
            //dbInitializer.Initialize(context).Wait();
        }
    }
}
