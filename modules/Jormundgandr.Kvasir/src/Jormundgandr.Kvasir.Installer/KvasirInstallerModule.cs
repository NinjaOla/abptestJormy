using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class KvasirInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<KvasirInstallerModule>();
        });
    }
}
