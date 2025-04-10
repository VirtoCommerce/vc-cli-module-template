namespace {Namespace}.Core;

public static class ModuleConstants
{
    public static class Security
    {
        public static class Permissions
        {
            public const string Create = "{KebabModuleName}:create";
            public const string Read = "{KebabModuleName}:read";
            public const string Update = "{KebabModuleName}:update";
            public const string Delete = "{KebabModuleName}:delete";

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
