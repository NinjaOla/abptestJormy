using Localization.Resources.AbpUi;
using AbpJormundgandr.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Jormundgandr.Kvasir;
using Jormundgandr.OrganizationManager;

namespace AbpJormundgandr;

[DependsOn(
    typeof(AbpJormundgandrApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
    [DependsOn(typeof(OrganizationManagerHttpApiModule))]
    [DependsOn(typeof(KvasirHttpApiModule))]
    public class AbpJormundgandrHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpJormundgandrResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
