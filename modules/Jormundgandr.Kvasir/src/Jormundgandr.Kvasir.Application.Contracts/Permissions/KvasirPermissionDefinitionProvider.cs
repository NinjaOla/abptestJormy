using Jormundgandr.Kvasir.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Jormundgandr.Kvasir.Permissions;

public class KvasirPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(KvasirPermissions.GroupName, L("Permission:Kvasir"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<KvasirResource>(name);
    }
}
