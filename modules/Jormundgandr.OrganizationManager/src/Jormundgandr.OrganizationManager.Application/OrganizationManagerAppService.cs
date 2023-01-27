using Jormundgandr.OrganizationManager.Localization;
using Volo.Abp.Application.Services;

namespace Jormundgandr.OrganizationManager;

public abstract class OrganizationManagerAppService : ApplicationService
{
    protected OrganizationManagerAppService()
    {
        LocalizationResource = typeof(OrganizationManagerResource);
        ObjectMapperContext = typeof(OrganizationManagerApplicationModule);
    }
}
