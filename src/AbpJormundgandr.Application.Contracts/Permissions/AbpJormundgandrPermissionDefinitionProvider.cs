using AbpJormundgandr.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpJormundgandr.Permissions;

public class AbpJormundgandrPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpJormundgandrPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpJormundgandrPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpJormundgandrResource>(name);
    }
}
