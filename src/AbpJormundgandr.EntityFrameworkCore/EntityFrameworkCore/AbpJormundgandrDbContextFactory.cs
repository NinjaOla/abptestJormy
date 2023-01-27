using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpJormundgandr.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpJormundgandrDbContextFactory : IDesignTimeDbContextFactory<AbpJormundgandrDbContext>
{
    public AbpJormundgandrDbContext CreateDbContext(string[] args)
    {
        AbpJormundgandrEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpJormundgandrDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpJormundgandrDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpJormundgandr.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
