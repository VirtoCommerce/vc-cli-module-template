using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace {Namespace}.Core
{
    public static class ModuleConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Access = "{ModuleName}:access";
                public const string Create = "{ModuleName}:create";
                public const string Read = "{ModuleName}:read";
                public const string Update = "{ModuleName}:update";
                public const string Delete = "{ModuleName}:delete";

                public static string[] AllPermissions { get; } =
                {
                    Access,
                    Create,
                    Read,
                    Update,
                    Delete,
                };
            }
        }

        public static class Settings
        {
            public static class General
            {
                public static SettingDescriptor {ModuleName}Enabled { get; } = new SettingDescriptor
                {
                    Name = "{ModuleName}.{ModuleName}Enabled",
                    GroupName = "{ModuleName}|General",
                    ValueType = SettingValueType.Boolean,
                    DefaultValue = false,
                };

                public static SettingDescriptor {ModuleName}Password { get; } = new SettingDescriptor
                {
                    Name = "{ModuleName}.{ModuleName}Password",
                    GroupName = "{ModuleName}|Advanced",
                    ValueType = SettingValueType.SecureString,
                    DefaultValue = "qwerty",
                };

                public static IEnumerable<SettingDescriptor> AllSettings
                {
                    get
                    {
                        yield return {ModuleName}Enabled;
                        yield return {ModuleName}Password;
                    }
                }
            }

            public static IEnumerable<SettingDescriptor> AllSettings
            {
                get
                {
                    return General.AllSettings;
                }
            }
        }
    }
}
