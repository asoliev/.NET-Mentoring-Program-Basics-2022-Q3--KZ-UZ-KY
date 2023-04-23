using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_Principles.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region connection to DB
var connStr = builder.Configuration.GetConnectionString("Northwind");
var conStrBuilder = new SqlConnectionStringBuilder(connStr)
{
    Password = builder.Configuration["DbPassword"]
};
var connection = conStrBuilder.ConnectionString;

builder.Services.AddDbContext<NorthwindContext>(opt => opt.UseSqlServer(connection));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();