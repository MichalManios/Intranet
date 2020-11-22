using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;
using ASdatabase;
using Microsoft.AspNetCore.Identity;
using Areszt_Śledczy_w_Łodzi.Services;
using System.Reflection;

namespace Areszt_Śledczy_w_Łodzi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<ASDbContextDatabase>(options => options.UseSqlServer("Server=DESKTOP-DOSSHB6\\SQLEXPRESS;Database=ASLodz;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<ASDbContextDatabase>();

            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IInstrukcjaRepository, InstrukcjaRepository>();
            services.AddScoped<IOgloszenieRepository, OgloszenieRepository>();
            services.AddScoped<ISizeFontRepository, SizeFontRepository>();
            services.AddScoped<IZarzadzenieRepository, ZarzadzenieRepository>();
            services.AddScoped<IFileUpload, FileUploadServices>();
            //services.AddScoped<ILoadOldZarzadzenia, LoadOldZarzadzenia>();
            services.AddScoped<IActualizationContentRepository, ActualizationContentRepository>();
            services.AddScoped<ASMapper>();
            services.AddScoped<OgloszenieServices>();
            services.AddScoped<FontSizeServices>();
            services.AddScoped<ColorServices>();
            services.AddScoped<InstrukcjaServices>();
            services.AddScoped<ZarzadzenieServices>();
            services.AddScoped<ActualizationContentServices>();

            //services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
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
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            //var database=serviceProvider.GetService<ASDbContextDatabase>();
            //database.Database.EnsureCreated();
            serviceProvider.GetService<ASDbContextDatabase>().Database.Migrate();
        }
    }
}
