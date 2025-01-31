using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Domain;
using {Namespace}.Core.Models;

namespace {Namespace}.Data.Models;

public class {EntityName}Entity : AuditableEntity, IDataEntity<{EntityName}Entity, {EntityName}>
{
    public virtual {EntityName} ToModel({EntityName} model)
    {
        model.Id = Id;
        model.CreatedBy = CreatedBy;
        model.CreatedDate = CreatedDate;
        model.ModifiedBy = ModifiedBy;
        model.ModifiedDate = ModifiedDate;

        return model;
    }

    public virtual {EntityName}Entity FromModel({EntityName} model, PrimaryKeyResolvingMap pkMap)
    {
        pkMap.AddPair(model, this);

        Id = model.Id;
        CreatedBy = model.CreatedBy;
        CreatedDate = model.CreatedDate;
        ModifiedBy = model.ModifiedBy;
        ModifiedDate = model.ModifiedDate;

        return this;
    }

    public virtual void Patch({EntityName}Entity target)
    {
    }
}
