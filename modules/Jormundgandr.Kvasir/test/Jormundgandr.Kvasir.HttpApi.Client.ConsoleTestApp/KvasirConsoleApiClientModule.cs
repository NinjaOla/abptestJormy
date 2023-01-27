using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(KvasirHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class KvasirConsoleApiClientModule : AbpModule
{

}
