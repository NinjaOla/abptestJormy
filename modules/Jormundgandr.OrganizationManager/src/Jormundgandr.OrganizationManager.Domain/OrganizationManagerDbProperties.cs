namespace Jormundgandr.OrganizationManager;

public static class OrganizationManagerDbProperties
{
    public static string DbTablePrefix { get; set; } = "OrganizationManager";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "OrganizationManager";
}
