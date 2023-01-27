using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(KvasirDomainSharedModule)
)]
public class KvasirDomainModule : AbpModule
{

}
