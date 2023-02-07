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
                // Add common FluentMigrator services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    // Add SQLite support to FluentMigrator
                    .AddSqlServer()
                    // Set the connection string
                    .WithGlobalConnectionString(ConfigurationManager.ConnectionStrings["ConexaoSistemaDeMercado"].ConnectionString)
                    // Define the assembly containing the migrations
                    .ScanIn(typeof(MetodosDeMigracao).Assembly).For.Migrations())
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                // Build the service provider
                .BuildServiceProvider(false);
        }

        /// <summary>
        /// Update the database
        /// </summary>
        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            runner.MigrateUp();
        }
    }
}
    