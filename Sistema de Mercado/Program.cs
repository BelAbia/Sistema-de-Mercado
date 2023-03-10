using System.Configuration;
using FluentMigrator.Runner;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Sistema_de_Mercado
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var builder = CriaHostBuilder();
            var servicesProvider = builder.Build().Services;
            var repositorio = servicesProvider.GetService<IRepositorio>();

            using (var serviceProvider = CriarServicos())
            using (var scope = serviceProvider.CreateScope())
            {
                AtualizarBancoDeDados(scope.ServiceProvider);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new JanelaDeLista(repositorio));
        }

        private static ServiceProvider CriarServicos()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(ConfigurationManager.ConnectionStrings["ConexaoSistemaDeMercado"].ConnectionString)
                    .ScanIn(typeof(MetodosDeMigracao).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

        static IHostBuilder CriaHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IRepositorio, RepositorioLinq2Db>();
                });
        }
    }
}