using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class OrganizationManagerApplicationContractsModule : AbpModule
{

}
