using Volo.Abp.Modularity;

namespace AbpJormundgandr;

[DependsOn(
    typeof(AbpJormundgandrApplicationModule),
    typeof(AbpJormundgandrDomainTestModule)
    )]
public class AbpJormundgandrApplicationTestModule : AbpModule
{

}
