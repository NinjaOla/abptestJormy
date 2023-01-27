using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpJormundgandr.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpJormundgandrBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpJormundgandr";
}
