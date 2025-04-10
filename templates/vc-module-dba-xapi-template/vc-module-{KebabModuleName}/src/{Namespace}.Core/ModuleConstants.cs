using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace {Namespace}.Core;

public static class ModuleConstants
{
    public static class Security
    {
        public static class Permissions
        {
            public const string Access = "{KebabModuleName}:access";
            public const string Create = "{KebabModuleName}:create";
            public const string Read = "{KebabModuleName}:read";
            public const string Update = "{KebabModuleName}:update";
            public const string Delete = "{KebabModuleName}:delete";

            public static string[] AllPermissions { get; } =
            [
                Access,
                Create,
                Read,
                Update,
                Delete,
            ];
        }
    }

    public static class Settings
    {
        public static class General
        {
            public static SettingDescriptor {ModuleName}Enabled { get; } = new()
            {
                Name = "{ModuleName}.Enabled",
                GroupName = "{ModuleName}|General",
                ValueType = SettingValueType.Boolean,
                DefaultValue = false,
            };

            public static IEnumerable<SettingDescriptor> AllGeneralSettings
            {
                get
                {
                    yield return {ModuleName}Enabled;
                }
            }
        }

        public static IEnumerable<SettingDescriptor> AllSettings
        {
            get
            {
                return General.AllGeneralSettings;
            }
        }
    }
}
