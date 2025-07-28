using AspCore2025.Classes.Configuration;
using AspCore2025.Models;
using AspCore2025.Models.Configuration;

namespace AspCore2025
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.SetupSerilog();
            builder.Services.SqlConnectionValidation(builder.Configuration);
            
            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.Configure<HelpDesk>(
                builder.Configuration.GetSection(nameof(HelpDesk)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}
