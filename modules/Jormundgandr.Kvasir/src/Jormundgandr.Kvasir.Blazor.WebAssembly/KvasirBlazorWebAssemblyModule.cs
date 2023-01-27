using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Jormundgandr.Kvasir.Blazor.WebAssembly;

[DependsOn(
    typeof(KvasirBlazorModule),
    typeof(KvasirHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class KvasirBlazorWebAssemblyModule : AbpModule
{

}
