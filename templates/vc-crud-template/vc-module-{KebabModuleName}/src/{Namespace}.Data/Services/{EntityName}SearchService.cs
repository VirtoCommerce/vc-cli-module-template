using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using VirtoCommerce.Platform.Core.Caching;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.GenericCrud;
using VirtoCommerce.Platform.Data.GenericCrud;
using {Namespace}.Core.Models;
using {Namespace}.Core.Services;
using {Namespace}.Data.Models;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.Services;

public class {EntityName}SearchService : SearchService<{EntityName}SearchCriteria, {EntityName}SearchResult, {EntityName}, {EntityName}Entity>, I{EntityName}SearchService
{
    public {EntityName}SearchService(
        Func<I{ModuleName}Repository> repositoryFactory,
        IPlatformMemoryCache platformMemoryCache,
        I{EntityName}Service crudService,
        IOptions<CrudOptions> crudOptions)
        : base(repositoryFactory, platformMemoryCache, crudService, crudOptions)
    {
    }

    protected override IQueryable<{EntityName}Entity> BuildQuery(IRepository repository, {EntityName}SearchCriteria criteria)
    {
        var query = ((I{ModuleName}Repository)repository).{EntityName}s;
        return query;
    }

    protected override IList<SortInfo> BuildSortExpression({EntityName}SearchCriteria criteria)
    {
        var sortInfos = criteria.SortInfos;

        if (sortInfos.IsNullOrEmpty())
        {
            sortInfos =
            [
                new SortInfo { SortColumn = nameof({EntityName}Entity.CreatedDate), SortDirection = SortDirection.Descending },
                new SortInfo { SortColumn = nameof({EntityName}Entity.Id) },
            ];
        }

        return sortInfos;
    }
}
