using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Woorj.Areas.Identity;
using Woorj.Data;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Woorj.Data.IndOrg;
using Woorj.Data.Dir;
using Woorj.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Woorj.Data.Adm;
using Microsoft.Extensions.Options;
using Woorj.CtrServerSide.Adm;
using Woorj.CtrServerSide.IndOrg;
using Woorj.CtrServerSide.Dir;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.FileProviders;
using System.IO;
using FluentValidation;

namespace Woorj
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            #region MainSettingRegion
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
            
                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<ApplicationRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

                services.AddRazorPages();
                services.AddServerSideBlazor();
                services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            // services.AddSingleton<WeatherForecastService>();
                services.AddHeadElementHelper();

                services.AddHttpContextAccessor();
                services.AddControllers();
            
            
                
            #endregion MainSettingRegion

            #region ForWebAPI


        
                    //Enable CORS
                services.AddCors(c =>
                {
                    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
                    .AllowAnyHeader());
                });

                //JSON Serializer How to Ignor the following issue:(A possible object cycle was detected which is not supported. )--On .Core 3.1 MS Changed the Security Policy 
                // Version 1
                /*
                services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling=ReferenceLoopHandling.Ignore); // ReferenceLoopHandling.Ignore
                */

                // Version 2
                services.AddControllersWithViews()
                    .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
                    .Json.ReferenceLoopHandling.Ignore)
                    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
                    = new DefaultContractResolver());
                    
    #endregion ForWebAPI
        
            #region EntityRegion
                services.AddScoped<ApplicationRoleController>();
                services.AddScoped<ApplicationUserController>();
                services.AddTransient<ServClass>();
                services.AddScoped<GenderController>();
                services.AddScoped<LanguageController>();
                services.AddScoped<CountryController>();
                
                services.AddScoped<IndividualController>();
                services.AddScoped<IValidator<Individual>, IndividualValidator>();
                
                services.AddScoped<ContactController>();
                services.AddScoped<EmployeeController>();
                services.AddScoped<AppData>();
                services.AddScoped<NavMeths>();
                services.AddScoped<GnrSrv>();

                services.AddScoped<ICustomTranslator, CustomTranslator>();
                services.AddScoped<ICoreService, CoreService>();
                services.AddScoped<IAdmService, AdmService>();
            #endregion EntityRegion
            
            #region LocalizationAndGlobalization
             /*
            // Method 1
             services.AddLocalization(options => options.ResourcesPath = "Resources");
            var supportedCultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("ru") };  
            services.Configure<RequestLocalizationOptions>(options =>  
            {  
               // options.DefaultRequestCulture = new RequestCulture("ru");  
                options.DefaultRequestCulture = new RequestCulture(culture: "ru", uiCulture: "ru"); 
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;  
            });
            */
            // Method 2
            services.AddLocalization(options => options.ResourcesPath = "Resources");
        
        #endregion LocalizationAndGlobalization

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region MainSettingRegion
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            /*
            // The App will not starting on IIS after uncommenting this code  
	
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"Photos")),
                RequestPath="/Photos"
            });
            */
		
         #endregion MainSettingRegion   
           
            #region ForWebAPI
              app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); 
              //  app.UseCors("Policy");
            #endregion ForWebAPI    

            #region LocalizationAndGlobalization
            /* 
            // Method 1
            app.UseRequestLocalization();  
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);
            */
            
            // Method 2
            var supportedCultures = new[]
                                {
                                    new CultureInfo("en"),
                                    new CultureInfo("ru"),
                                };
             app.UseRequestLocalization(new RequestLocalizationOptions
                                   {
                                       DefaultRequestCulture = new RequestCulture("ru"),
                                       SupportedCultures = supportedCultures,
                                       SupportedUICultures = supportedCultures
                                   });

            #endregion LocalizationAndGlobalization
            
            #region MainSettingRegion2
                app.UseRouting();

                app.UseAuthentication();
                app.UseAuthorization();
                // Use  app.UseEndpoints instead  app.MVC on net Core 2
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapBlazorHub();
                    endpoints.MapFallbackToPage("/_Host");
                });
                     
            #endregion MainSettingRegion2
        }
    }
}
