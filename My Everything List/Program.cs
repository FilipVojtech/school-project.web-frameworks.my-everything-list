using Microsoft.AspNetCore.Authentication.Cookies;
using My_Everything_List.Components;
using Microsoft.EntityFrameworkCore;
using My_Everything_List.Data;

namespace My_Everything_List;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "auth";
                // options.Cookie.MaxAge = TimeSpan.FromHours(24);
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/access-denied";
            });
        builder.Services.AddAuthorization();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddDbContext<My_Everything_ListContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("My_Everything_ListContext") ??
                              throw new InvalidOperationException(
                                  "Connection string 'My_Everything_ListContext' not found.")
            )
        );
        builder.Services.AddQuickGridEntityFrameworkAdapter();
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            // todo: Monitor if being in the if-block causes any issues
            app.UseMigrationsEndPoint();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
