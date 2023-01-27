using Jormundgandr.Kvasir.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Jormundgandr.Kvasir;

public abstract class KvasirController : AbpControllerBase
{
    protected KvasirController()
    {
        LocalizationResource = typeof(KvasirResource);
    }
}
