using System;
using VirtoCommerce.Platform.Core.Common;

namespace {Namespace}.Core.Models;

public class {EntityName} : AuditableEntity, ICloneable
{
    public object Clone()
    {
        return MemberwiseClone();
    }
}
