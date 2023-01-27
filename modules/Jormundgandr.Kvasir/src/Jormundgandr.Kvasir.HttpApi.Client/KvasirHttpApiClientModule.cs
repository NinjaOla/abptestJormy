using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(KvasirApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class KvasirHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(KvasirApplicationContractsModule).Assembly,
            KvasirRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<KvasirHttpApiClientModule>();
        });

    }
}
