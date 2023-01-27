using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpJormundgandr.Data;
using Volo.Abp.DependencyInjection;

namespace AbpJormundgandr.EntityFrameworkCore;

public class EntityFrameworkCoreAbpJormundgandrDbSchemaMigrator
    : IAbpJormundgandrDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpJormundgandrDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpJormundgandrDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpJormundgandrDbContext>()
            .Database
            .MigrateAsync();
    }
}
