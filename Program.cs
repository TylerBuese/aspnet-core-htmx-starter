using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using HtmxStarter.Data;
using HtmxStarter.Interfaces;
using HtmxStarter.Middleware;
using HtmxStarter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRenderView, RenderView>();
builder.Services.AddTransient<ITodoService, TodoService>();

//Add sqlite, put your database here
builder.Services.AddDbContext<Context>(o => o.UseSqlite("Data Source=todo.db"));
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

app.UseAuthorization();

app.MapRazorPages();

// app.UseMiddleware<RenderMiddleware>();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}"
	);

app.Run();
