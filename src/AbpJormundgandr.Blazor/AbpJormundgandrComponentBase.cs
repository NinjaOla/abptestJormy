using AbpJormundgandr.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpJormundgandr.Blazor;

public abstract class AbpJormundgandrComponentBase : AbpComponentBase
{
    protected AbpJormundgandrComponentBase()
    {
        LocalizationResource = typeof(AbpJormundgandrResource);
    }
}
