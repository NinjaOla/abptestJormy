using System.Threading.Tasks;

namespace AbpJormundgandr.Data;

public interface IAbpJormundgandrDbSchemaMigrator
{
    Task MigrateAsync();
}
