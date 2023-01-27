using Jormundgandr.Kvasir.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jormundgandr.Kvasir;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(KvasirEntityFrameworkCoreTestModule)
    )]
public class KvasirDomainTestModule : AbpModule
{

}
