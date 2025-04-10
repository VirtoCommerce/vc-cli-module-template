using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Events;
using {Namespace}.Core.Models;

namespace {Namespace}.Core.Events;

public class {EntityName}ChangingEvent(IEnumerable<GenericChangedEntry<{EntityName}>> changedEntries)
    : GenericChangedEntryEvent<{EntityName}>(changedEntries);
