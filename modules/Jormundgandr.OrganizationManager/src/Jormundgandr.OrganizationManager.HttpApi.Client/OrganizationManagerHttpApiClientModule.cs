using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class OrganizationManagerHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(OrganizationManagerApplicationContractsModule).Assembly,
            OrganizationManagerRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrganizationManagerHttpApiClientModule>();
        });

    }
}
