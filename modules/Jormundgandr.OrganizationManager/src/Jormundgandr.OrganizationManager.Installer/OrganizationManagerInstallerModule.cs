using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class OrganizationManagerInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrganizationManagerInstallerModule>();
        });
    }
}
