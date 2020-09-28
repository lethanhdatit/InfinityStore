using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infinity.Data;
using Infinity.UnitOfWork;
using Infinity.Services;
using Infinity.Store;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.OAuth;
using IdentityModel;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.Extensions.Options;

namespace InfinityStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AutoMapperConfiguration.Config();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddViewLocalization(options => options.ResourcesPath = "Resources")
                .AddDataAnnotationsLocalization();

            services.AddSingleton(provider => Configuration);

            services.AddDbContext<MyIdentityDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MainConnection")));

            services.AddDbContext<InfinityStoreDBContext>
            (options => options.UseSqlServer(Configuration.GetConnectionString("MainConnection")));

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddTransient<GlobalSettingService>();
            //services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("vi")
                };

                options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            services.AddDefaultIdentity<ApplicationUser>(options => { 
                options.SignIn.RequireConfirmedAccount = false;

                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            })
            .AddEntityFrameworkStores<MyIdentityDbContext>();

            services.AddAuthentication()
            .AddFacebook(o =>
            {
                o.AppId = Configuration.GetValue<string>("Providers:Facebook:AppId");
                o.AppSecret = Configuration.GetValue<string>("Providers:Facebook:AppSecret");
                o.AccessDeniedPath = "/Home/Index";
                o.Scope.Add("email");
                o.Scope.Add("public_profile");
                o.Events.OnCreatingTicket = (context) =>
                {
                    var id = context.User.GetProperty("id");
                    context.Identity.AddClaim(new Claim(JwtClaimTypes.Picture, $"https://graph.facebook.com/{id}/picture?type=large"));
                    return Task.CompletedTask;
                };
            })
            .AddGoogle(o =>
            {
                o.ClientId = Configuration.GetValue<string>("Providers:Google:ClientId");
                o.ClientSecret = Configuration.GetValue<string>("Providers:Google:ClientSecret");
                o.AccessDeniedPath = "/Home/Index";
                o.Scope.Add("profile");
                o.Events.OnCreatingTicket = (context) =>
                {
                    var picture = context.User.GetProperty("picture").GetString();
                    context.Identity.AddClaim(new Claim(JwtClaimTypes.Picture, picture));
                    return Task.CompletedTask;
                };
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            //services.AddMvc().AddDataAnnotationsLocalization(options => {
            //                 options.DataAnnotationLocalizerProvider = (type, factory) =>
            //                 factory.Create(typeof(SharedResource));
            //services.AddLocalization(options => options.ResourcesPath = "Resources");

            //services.AddMvc()
            //    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            //    .AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "AdminArea",
                    areaName: "admin",
                    pattern: "admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
