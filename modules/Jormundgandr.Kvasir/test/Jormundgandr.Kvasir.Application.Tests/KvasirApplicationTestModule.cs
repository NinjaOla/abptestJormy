using Volo.Abp.Modularity;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(KvasirApplicationModule),
    typeof(KvasirDomainTestModule)
    )]
public class KvasirApplicationTestModule : AbpModule
{

}
