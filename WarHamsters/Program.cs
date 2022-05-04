global using Microsoft.EntityFrameworkCore;
global using DataLibrary.Data;
global using DataLibrary.Services;
global using DataLibrary.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<HamsterService>();
builder.Services.AddScoped<HamsterRepository>();
builder.Services.AddScoped<MatchService>();
builder.Services.AddScoped<MatchRepository>();

var cs = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContextFactory<DataContext>(opt => opt.UseSqlServer(cs));
builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(cs));
builder.Services.AddTransient<IStartupFilter, MigrationStartupFilter<DataContext>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
