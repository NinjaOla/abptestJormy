using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Jormundgandr.Kvasir;

[DependsOn(
    typeof(KvasirDomainModule),
    typeof(KvasirApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class KvasirApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<KvasirApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<KvasirApplicationModule>(validate: true);
        });
    }
}
