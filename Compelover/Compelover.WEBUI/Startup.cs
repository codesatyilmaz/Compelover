using System;
using AutoMapper;
using Compelover.Business.Notional;
using Compelover.Business.Tangible;
using Compelover.DataAccess.EntityFrameworkCore.ContextFile;
using Compelover.DataAccess.Notional;
using Compelover.DataAccess.Tangible;
using Compelover.Entities.Tangible;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
namespace Compelover.WEBUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
                options.EnableEndpointRouting =
                    false);
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IBlogDal, EfBlogDal>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddDbContext<CompeloverContext>();
            services.AddAutoMapper(typeof(Startup));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false; //0-9 Sayılar girmesin.
                options.Password.RequireNonAlphanumeric = false; // @ # & () - [{}]:; ',? / * bunlar olmasın.
                options.User.RequireUniqueEmail = true; //sistem'de sadece bir tane e-mail olur.
                options.User.AllowedUserNameCharacters =
                    "abcçdefghıijklmnoöpqrsştuüvwxyzABCÇDEFGHİIJKLMNOÖPQRSŞTÜUVWXYZ0123456789-._";
            }).AddEntityFrameworkStores<CompeloverContext>();
            // AddPasswordValidator<CustomPasswordValidator>().AddUserValidator<CustomUserValidator>()
            //     .AddEntityFrameworkStores<AppIdentityDbContext>().AddErrorDescriber<CustomIdentityErrorDescriber>()
            //     .AddDefaultTokenProviders();
            var configureApplicationCookie = services.ConfigureApplicationCookie(configure =>
            {
                configure.Cookie.Name = "OpenTestSystem"; //login old zaman bunu kaydedicek.
                configure.Cookie.HttpOnly = false; //kötü niyetli kullanıcılar client taraf'ta cooki'ye ulaşmasınlar.
                configure.ExpireTimeSpan = TimeSpan.FromDays(10); //ne kadar süre kullanıcın bilgileri sistem'de kalsın.
                configure.Cookie.SameSite =
                    SameSiteMode.Lax; //Cooki kayıt old zaman o site üzerinden bu cookiye ulaşılacak.
                configure.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                configure.LoginPath =
                    "/Home/Login"; //kullanıcı üye olmadan yetki isterse bu kullanıcıyı login sayfasına yönlendirelim.
                // configure.LogoutPath = "";//
                configure.SlidingExpiration = true;
                //belirlenen ömrün yarısın'da yani 60 'dı 30 olunca kullanıcı tekrar istek atınca yeniden 60 olması
                configure.AccessDeniedPath =
                    new PathString(
                        "/Member/AccessDenied"); //eğer kullanıcı üye olduktan sonra admine tıklarsa onu bu sayfaya erişemediğini bildirecek.
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                //Area için.
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{action=Index}/{id?}"
                );
            });
            
        }
    }
}