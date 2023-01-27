using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpJormundgandr.Data;

/* This is used if database provider does't define
 * IAbpJormundgandrDbSchemaMigrator implementation.
 */
public class NullAbpJormundgandrDbSchemaMigrator : IAbpJormundgandrDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
