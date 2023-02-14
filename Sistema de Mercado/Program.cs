using System;
using System.Configuration;

using FluentMigrator.Runner;

using Microsoft.Extensions.DependencyInjection;


namespace Sistema_de_Mercado
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var serviceProvider = CriarServicos())
            using (var scope = serviceProvider.CreateScope())
            {
                AtualizarBancoDeDados(scope.ServiceProvider);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new JanelaDeLista());
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
    }
}
