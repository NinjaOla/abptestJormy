using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerApplicationModule),
    typeof(OrganizationManagerDomainTestModule)
    )]
public class OrganizationManagerApplicationTestModule : AbpModule
{

}
