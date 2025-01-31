using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Common;
using {Namespace}.Data.Models;

namespace {Namespace}.Data.Repositories;

public interface I{ModuleName}Repository : IRepository
{
    IQueryable<{EntityName}Entity> {EntityName}s { get; }

    Task<IList<{EntityName}Entity>> Get{EntityName}sByIdsAsync(IList<string> ids, string responseGroup);
}
