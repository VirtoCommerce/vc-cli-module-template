using System;
using VirtoCommerce.Platform.Core.Common;

namespace {Namespace}.Core.Models;

public class {EntityName} : AuditableEntity, ICloneable
{
    public virtual object Clone()
    {
        return MemberwiseClone();
    }
}
