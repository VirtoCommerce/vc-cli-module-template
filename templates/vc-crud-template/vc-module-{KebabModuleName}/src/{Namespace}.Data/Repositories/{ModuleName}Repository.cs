using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Domain;
using VirtoCommerce.Platform.Data.Infrastructure;
using {Namespace}.Data.Models;

namespace {Namespace}.Data.Repositories;

public class {ModuleName}Repository : DbContextRepositoryBase<{ModuleName}DbContext>, I{ModuleName}Repository
{
    public {ModuleName}Repository({ModuleName}DbContext dbContext, IUnitOfWork unitOfWork = null)
        : base(dbContext, unitOfWork)
    {
    }

    public IQueryable<{EntityName}Entity> {EntityName}s => DbContext.Set<{EntityName}Entity>();

    public virtual async Task<IList<{EntityName}Entity>> Get{EntityName}sByIdsAsync(IList<string> ids, string responseGroup)
    {
        if (ids.IsNullOrEmpty())
        {
            return [];
        }

        return ids.Count == 1
            ? await {EntityName}s.Where(x => x.Id == ids.First()).ToListAsync()
            : await {EntityName}s.Where(x => ids.Contains(x.Id)).ToListAsync();
    }
}
