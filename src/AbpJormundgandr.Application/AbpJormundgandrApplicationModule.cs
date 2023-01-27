using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Jormundgandr.Kvasir;
using Jormundgandr.OrganizationManager;

namespace AbpJormundgandr;

[DependsOn(
    typeof(AbpJormundgandrDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpJormundgandrApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(OrganizationManagerApplicationModule))]
    [DependsOn(typeof(KvasirApplicationModule))]
    public class AbpJormundgandrApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpJormundgandrApplicationModule>();
        });
    }
}
