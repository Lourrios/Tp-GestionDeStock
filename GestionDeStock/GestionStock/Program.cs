using GestionDeStock.Business.Autenticacion;
using GestionDeStock.Business.Implements;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Implements;
using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GestionStock
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();



            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;


            Application.Run(ServiceProvider.GetRequiredService<login>());



        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()

                .ConfigureServices((context, services) =>
                {

                    var StockConnection = "Persist Security Info=True;Initial Catalog=GestionStock;Data Source=.;Application Name=DemoApp;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";



                    services.AddDbContext<GestionDeStockContext>(options =>
                       options.UseSqlServer(StockConnection));
                    // Configura tu DbContext
                    //services.AddDbContext<GestionDeStockContext>(options =>
                    //    options.UseSqlServer(context.Configuration.GetConnectionString("StockConnection")));


                    services.AddTransient<IProductoRepository, ProductoRepository>();
                    services.AddTransient<IUsuarioRepository, UsuarioRepository>();
                    services.AddTransient<ICategoriaRepository, CategoriaRespository>();
                    services.AddTransient<IVentaRepository, VentaRepository>();
                    services.AddTransient<ICompraRepository, CompraRespository>();
                    services.AddTransient<IPasswordHasher, PasswordHasher>();
                    services.AddTransient<ILoginUsuario, LoginUsuario>();
                    services.AddTransient<IProductoBusiness, ProductoBusiness>();
                    services.AddTransient<IStockBusiness, StockBusiness>();
                    services.AddTransient<ICategoriaBusiness, CategoriaBusiness>();
                    services.AddTransient<login>();
                    services.AddTransient<Menu>();
                    services.AddTransient<categorias>();
                    services.AddTransient<Productos_por_Categoria>();
                    services.AddTransient<ventas>();
                    services.AddTransient<compras>();
                    services.AddTransient<agregar>();
                    services.AddTransient<Editar>();


                });
        }
    }
}