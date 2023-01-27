using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AbpJormundgandr.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace AbpJormundgandr;

/* Inherit your application services from this class.
 */
public abstract class AbpJormundgandrAppService : ApplicationService
{
    protected AbpJormundgandrAppService()
    {
        LocalizationResource = typeof(AbpJormundgandrResource);
    }
}
