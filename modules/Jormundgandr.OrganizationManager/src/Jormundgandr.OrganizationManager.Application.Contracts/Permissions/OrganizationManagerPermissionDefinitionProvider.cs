using Jormundgandr.OrganizationManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Jormundgandr.OrganizationManager.Permissions;

public class OrganizationManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrganizationManagerPermissions.GroupName, L("Permission:OrganizationManager"));
        var x = myGroup.AddPermission(OrganizationManagerPermissions.GroupName + "Teams_Management", null, Volo.Abp.MultiTenancy.MultiTenancySides.Tenant, false);
        x.AddChild("Teams_Management_Create_Teams");
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrganizationManagerResource>(name);
    }
}
