using AbpJormundgandr.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpJormundgandr.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpJormundgandrEntityFrameworkCoreModule),
    typeof(AbpJormundgandrApplicationContractsModule)
    )]
public class AbpJormundgandrDbMigratorModule : AbpModule
{

}
