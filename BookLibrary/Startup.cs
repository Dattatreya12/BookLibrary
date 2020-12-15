using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.CommonConnection;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookLibrary
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
            services.AddControllersWithViews();

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            //services.AddSingleton<myConnection>(_ => new myConnection(Configuration["ConnectionStrings:Default"]));
            // services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("core")));
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IBookRepository<BookModel>, BookRepository>();
            services.AddScoped<BookRepository, BookRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddTransient<IBhagyastoreRepoitory<Bhagyastorage>, BhagyaRepository>();

            services.AddMemoryCache();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
