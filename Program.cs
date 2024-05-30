using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Sistema_De_Ahorro_y_Prestamos_v2.Interface;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICliente, ClienteRepository>();
builder.Services.AddScoped<Ioinversion, InversionistaRepository>();
builder.Services.AddScoped<IPrestamo, PrestamoRepository>();
builder.Services.AddScoped<IPrestamo, PrestamoRepository>();
builder.Services.AddScoped<IGarantia, GarantiaRepository>();

builder.Services.AddDbContext<ahorro_prestamoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion"));
});
builder.Services.AddIdentity<User, IdentityRole>()
.AddEntityFrameworkStores<ahorro_prestamoDbContext>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie();
var app = builder.Build();

if(args.Length == 1 && args[0].ToLower() == "seeddata"){
    
    await Seed.SeedUserAndRoles(app);

}

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
