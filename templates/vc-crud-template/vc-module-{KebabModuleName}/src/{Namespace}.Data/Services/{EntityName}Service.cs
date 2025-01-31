using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Caching;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Events;
using VirtoCommerce.Platform.Data.GenericCrud;
using {Namespace}.Core.Events;
using {Namespace}.Core.Models;
using {Namespace}.Core.Services;
using {Namespace}.Data.Models;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Data.Services;

public class {EntityName}Service : CrudService<{EntityName}, {EntityName}Entity, {EntityName}ChangingEvent, {EntityName}ChangedEvent>, I{EntityName}Service
{
    public {EntityName}Service(
        Func<I{ModuleName}Repository> repositoryFactory,
        IPlatformMemoryCache platformMemoryCache,
        IEventPublisher eventPublisher)
        : base(repositoryFactory, platformMemoryCache, eventPublisher)
    {
    }

    protected override Task<IList<{EntityName}Entity>> LoadEntities(IRepository repository, IList<string> ids, string responseGroup)
    {
        return ((I{ModuleName}Repository)repository).Get{EntityName}sByIdsAsync(ids, responseGroup);
    }
}
