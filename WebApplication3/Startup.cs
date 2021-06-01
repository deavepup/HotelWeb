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
            //SQL Server veritaban� sa�lay�c�s�n� kullanacak �ekilde yap�land�r�l�r
            services.AddDbContext<HotelWebContext>(options =>
options.UseSqlServer(Configuration.GetConnectionString("connection")));
            //Y�nlendirmenin i� noktalar� dahili olarak mi yoksa eski y�nlendirme mant���n�n mi kullan�laca��n� belirleyen bir de�er al�r veya ayarlar.
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            //Bu uzant� y�ntemleri, uygun ayarlarla �emalar� kaydetmek i�in (Authenticationbuilder. AddScheme )kullan�r.
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

            //wwwroot klas�r�nde yer alan dosyalara do�rudan eri�im imkan� vermektedir.
            app.UseStaticFiles();
            //Kimlik Do�rulama
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
