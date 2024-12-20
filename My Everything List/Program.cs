﻿using Microsoft.AspNetCore.Authentication.Cookies;
using My_Everything_List.Components;
using Microsoft.EntityFrameworkCore;
using My_Everything_List.Data;
using My_Everything_List.Services.GoogleBooksService;
using My_Everything_List.Services.LastfmService;
using My_Everything_List.Services.TmdbService;
using My_Everything_List.Services.UserService;

namespace My_Everything_List;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "auth";
                options.Cookie.MaxAge = TimeSpan.FromDays(7);
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/access-denied";
            });

        builder.Services.AddAuthorization();

        builder.Services.AddCascadingAuthenticationState();

        builder.Services.AddDbContextFactory<MyEverythingListContext>(options =>
            options.UseSqlite(
                builder.Configuration.GetConnectionString("My_Everything_ListContext") ??
                throw new InvalidOperationException("Connection string 'My_Everything_ListContext' not found.")
            )
        );

        builder.Services.AddQuickGridEntityFrameworkAdapter();

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        // Services
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddSingleton<ITmdbService, TmdbService>(_ =>
            new TmdbService(builder.Configuration.GetConnectionString("TmdbApiKey") ??
                            throw new InvalidOperationException("Connection TmdbApiKey not found.")));
        builder.Services.AddSingleton<IGoogleBooksService, GoogleBooksService>();
        builder.Services.AddSingleton<ILastfmService, LastfmService>(_ =>
            new LastfmService(builder.Configuration.GetConnectionString("LastfmApiKey") ??
                              throw new InvalidOperationException("LastfmApiKey not found.")));

        // Bootstrap
        builder.Services.AddBlazorBootstrap();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
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
