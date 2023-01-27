using Jormundgandr.OrganizationManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(OrganizationManagerEntityFrameworkCoreTestModule)
    )]
public class OrganizationManagerDomainTestModule : AbpModule
{

}
