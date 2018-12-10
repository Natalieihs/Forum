using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Extensions;
using Forum.Services.Implements;
using Forum.Services.Interfaces;
using Forum.Web.Middleware;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NLog.Extensions.Logging;
using NLog.Web;

namespace Forum.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            this.Configuration = builder.Build();
            BaseConfigModel.SetBaseConfig(Configuration, env.ContentRootPath, env.WebRootPath);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region 注册服务
            services.AddTransient<IonlineusersService, onlineusersService>();
            services.AddTransient<ISysUserInfoService, SysUserInfoService>();
            services.AddTransient<ISysmenuService, SysmenuService>();
            #endregion

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            // .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
            // {
            //     o.LoginPath = new PathString("/Account/login");
            // }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
            // {
            //     JwtAuthConfigModel jwtConfig = new JwtAuthConfigModel();
            //     o.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         ValidIssuer = "FytSos",
            //         ValidAudience = "wr",
            //         IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.JWTSecretKey)),
            //         RequireSignedTokens = true,
            //         ValidateAudience = false,
            //         ValidateIssuer = true,
            //         ValidateIssuerSigningKey = true,
            //         RequireExpirationTime = true,
            //         ValidateLifetime = true
            //     };
            // });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireApp", policy => policy.RequireRole("App").Build());
                options.AddPolicy("RequireAdmin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("RequireAdminOrApp", policy => policy.RequireRole("Admin,App").Build());
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
           // var security = new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } }, };

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            loggerFactory.AddNLog();
            //读取Nlog配置文件
            //读取Nlog配置文件 
            env.ConfigureNLog("nlog.config");
            //自定义异常处理
            app.UseMiddleware<ExceptionFilter>();
            //认证
            //app.UseAuthentication();
            //授权
            //app.UseMiddleware<JwtAuthorizationFilter>();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=menu}/{action=Index}/{id?}");
            });
        }
    }
}
