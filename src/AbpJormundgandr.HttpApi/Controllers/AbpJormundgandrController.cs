using AbpJormundgandr.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpJormundgandr.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpJormundgandrController : AbpControllerBase
{
    protected AbpJormundgandrController()
    {
        LocalizationResource = typeof(AbpJormundgandrResource);
    }
}
