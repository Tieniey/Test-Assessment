using _2C2PTest.Services;
using Microsoft.AspNetCore.Builder;

namespace _2C2PTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            // Add services to the container.
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<UploadServices>();
            services.AddSingleton<WeatherForecastService>();
            //services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddDevExpressBlazor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/ Error");
            }

            //app.UseRequestLocalization();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
