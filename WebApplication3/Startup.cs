using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace WebApplication3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //SQL Server veritabaný saðlayýcýsýný kullanacak þekilde yapýlandýrýlýr
            services.AddDbContext<HotelWebContext>(options =>
options.UseSqlServer(Configuration.GetConnectionString("connection")));
            //Yönlendirmenin iç noktalarý dahili olarak mi yoksa eski yönlendirme mantýðýnýn mi kullanýlacaðýný belirleyen bir deðer alýr veya ayarlar.
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            //Bu uzantý yöntemleri, uygun ayarlarla þemalarý kaydetmek için (Authenticationbuilder. AddScheme )kullanýr.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>{
                x.LoginPath = "/Admin/Admin/Login";

            }
            );
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public string WebApplication3Context { get; private set; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseHttpsRedirection();

            //wwwroot klasöründe yer alan dosyalara doðrudan eriþim imkaný vermektedir.
            app.UseStaticFiles();
            //Kimlik Doðrulama
            app.UseAuthentication();
            app.UseAuthorization();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHsts();
            }
            else
            {
                app.UseExceptionHandler("/Error/Index");
            }


            /*  app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}/{id?}"
                  );
              });*/


            app.UseMvc(routes =>
            {
                routes.MapRoute(
              name: "area",
              template: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
