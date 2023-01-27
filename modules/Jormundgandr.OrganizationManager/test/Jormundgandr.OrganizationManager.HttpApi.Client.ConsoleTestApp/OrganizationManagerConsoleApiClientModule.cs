using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrganizationManagerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class OrganizationManagerConsoleApiClientModule : AbpModule
{

}
