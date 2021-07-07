using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineKrasotka.Domain;
using OnlineKrasotka.Domain.Entities.Cart;
using OnlineKrasotka.Domain.Repository.EntityFramework;
using OnlineKrasotka.Domain.Repository.Interfaces;
using OnlineKrasotka.Service;

namespace OnlineKrasotka
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            //Подключаем нужный функционал в качестве сервисов
            services.AddTransient<ITextFields, EFTextFieldsRepository>();
            services.AddTransient<IThingItems, EFThingItemsRepository>();
            services.AddTransient<IAllOrders, OrderRepository>();
            services.AddTransient<DataManager>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//эта строка кода позволяем нам работать с сессиями
            services.AddScoped(sp => Cart.GetCart(sp));//Эта строка кода позволяем сделать разные корзины для разных пользователей
            services.AddMemoryCache();//В этой строке кода мы говорим, что будем использовать кэш
            services.AddSession();

            //Подключаем контекст БД
            services.AddDbContext<AppDb>(x => x.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IsiKrasotka;Persist Security Info=false;User ID='sa';Password='sa';MultipleActiveResultSets=true;Trusted_Connection=True"));

            //Настраиваем Identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDb>().AddDefaultTokenProviders();

            //Настраиваем authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            //services.AddAuthorization(x =>
            //{
            //    x.AddPolicy("AdminArea", policy => { policy.RequireRole("Admin"); });
            //});
            //Настраиваем политику авторизации для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });


            services.AddControllersWithViews(x => { x.Conventions.Add(new AreaAdminAuthorization("Admin", "AdminArea")); })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//поддержка статических файлов
            app.UseSession();
            app.UseRouting();//система маршрутизации

            //Подключаем аутентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                
                //endpoints.MapControllerRoute("Admin", "{area:exists}/{controller=ThingItems}/{action=Edit}/{id?}");
            }); 
        }
    }
}
