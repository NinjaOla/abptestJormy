using Localization.Resources.AbpUi;
using Jormundgandr.OrganizationManager.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Jormundgandr.OrganizationManager;

[DependsOn(
    typeof(OrganizationManagerApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class OrganizationManagerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(OrganizationManagerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(OrganizationManagerApplicationContractsModule).Assembly);
        });
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<OrganizationManagerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
