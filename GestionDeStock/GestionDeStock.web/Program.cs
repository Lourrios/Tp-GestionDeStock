using GestionDeStock;
using GestionDeStock.Business.Autenticacion;
using GestionDeStock.Business.Implements;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Implements;
using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GestionDeStockContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("StockConnection")));

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSession();

builder.Services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<ICompraRepository, CompraRespository>();
builder.Services.AddScoped<ICompraBusiness, CompraBusiness>();
builder.Services.AddScoped<ICategoriaBusiness, CategoriaBusiness>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRespository>();
builder.Services.AddScoped<IStockBusiness, StockBusiness>();
builder.Services.AddScoped<IVentaBusiness, VentaBusiness>();
builder.Services.AddScoped<IVentaRepository, VentaRepository>();
builder.Services.AddScoped<ILoginUsuario, LoginUsuario>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=LogIn}/{id?}");

app.Run();
