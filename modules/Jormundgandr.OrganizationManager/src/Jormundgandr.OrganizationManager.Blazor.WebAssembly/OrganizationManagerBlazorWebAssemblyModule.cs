using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager.Blazor.WebAssembly;

[DependsOn(
    typeof(OrganizationManagerBlazorModule),
    typeof(OrganizationManagerHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class OrganizationManagerBlazorWebAssemblyModule : AbpModule
{

}
