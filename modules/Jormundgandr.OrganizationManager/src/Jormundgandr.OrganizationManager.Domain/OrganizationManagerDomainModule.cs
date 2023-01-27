using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrganizationManagerDomainSharedModule)
)]
public class OrganizationManagerDomainModule : AbpModule
{

}
