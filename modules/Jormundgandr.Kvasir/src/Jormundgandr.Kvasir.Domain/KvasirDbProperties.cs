namespace Jormundgandr.Kvasir;

public static class KvasirDbProperties
{
    public static string DbTablePrefix { get; set; } = "Kvasir";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Kvasir";
}
