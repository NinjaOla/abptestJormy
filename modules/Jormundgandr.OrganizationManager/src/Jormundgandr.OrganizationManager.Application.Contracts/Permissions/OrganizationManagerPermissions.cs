using Volo.Abp.Reflection;

namespace Jormundgandr.OrganizationManager.Permissions;

public class OrganizationManagerPermissions
{
    public const string GroupName = "OrganizationManager";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrganizationManagerPermissions));
    }
}
