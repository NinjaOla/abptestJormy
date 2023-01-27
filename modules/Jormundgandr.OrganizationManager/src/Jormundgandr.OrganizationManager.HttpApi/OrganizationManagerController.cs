using Jormundgandr.OrganizationManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Jormundgandr.OrganizationManager;

public abstract class OrganizationManagerController : AbpControllerBase
{
    protected OrganizationManagerController()
    {
        LocalizationResource = typeof(OrganizationManagerResource);
    }
}
