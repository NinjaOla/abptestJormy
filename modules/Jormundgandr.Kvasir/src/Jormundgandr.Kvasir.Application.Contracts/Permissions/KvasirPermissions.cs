using Volo.Abp.Reflection;

namespace Jormundgandr.Kvasir.Permissions;

public class KvasirPermissions
{
    public const string GroupName = "Kvasir";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(KvasirPermissions));
    }
}
