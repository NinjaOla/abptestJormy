using Localization.Resources.AbpUi;
using Jormundgandr.Kvasir.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(KvasirApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class KvasirHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(KvasirHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<KvasirResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
