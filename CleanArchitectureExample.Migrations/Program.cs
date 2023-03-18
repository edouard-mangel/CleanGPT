using FluentMigrator.Runner;

using Microsoft.Extensions.DependencyInjection;

using Npgsql;

using System;

var connectionString = Environment.GetEnvironmentVariable("POSTGRESQL_CONNECTION_STRING");

var services = new ServiceCollection()
    .AddFluentMigratorCore()
    .ConfigureRunner(rb => rb
        .AddPostgres()
        .WithGlobalConnectionString(connectionString)
        .ScanIn(typeof(Program).Assembly).For.Migrations())
    .AddLogging(lb => lb.AddFluentMigratorConsole())
    .BuildServiceProvider(false);

using (var scope = services.CreateScope()) {
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}
