using Jormundgandr.Kvasir.Localization;
using Volo.Abp.Application.Services;

namespace Jormundgandr.Kvasir;

public abstract class KvasirAppService : ApplicationService
{
    protected KvasirAppService()
    {
        LocalizationResource = typeof(KvasirResource);
        ObjectMapperContext = typeof(KvasirApplicationModule);
    }
}
