using AbpJormundgandr.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpJormundgandr;

[DependsOn(
    typeof(AbpJormundgandrEntityFrameworkCoreTestModule)
    )]
public class AbpJormundgandrDomainTestModule : AbpModule
{

}
