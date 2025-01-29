namespace {Namespace}.Core;

public static class ModuleConstants
{
    public static class Security
    {
        public static class Permissions
        {
            public const string Create = "{ModuleName}:create";
            public const string Read = "{ModuleName}:read";
            public const string Update = "{ModuleName}:update";
            public const string Delete = "{ModuleName}:delete";

            public static string[] AllPermissions { get; } =
            [
                Create,
                Read,
                Update,
                Delete,
            ];
        }
    }
}
