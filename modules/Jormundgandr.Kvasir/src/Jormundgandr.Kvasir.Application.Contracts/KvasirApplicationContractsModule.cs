using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(KvasirDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class KvasirApplicationContractsModule : AbpModule
{

}
