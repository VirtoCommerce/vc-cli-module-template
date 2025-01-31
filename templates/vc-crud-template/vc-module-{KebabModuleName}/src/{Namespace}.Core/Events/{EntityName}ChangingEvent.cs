using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Events;
using {Namespace}.Core.Models;

namespace {Namespace}.Core.Events;

public class {EntityName}ChangingEvent : GenericChangedEntryEvent<{EntityName}>
{
    public {EntityName}ChangingEvent(IEnumerable<GenericChangedEntry<{EntityName}>> changedEntries)
        : base(changedEntries)
    {
    }
}
