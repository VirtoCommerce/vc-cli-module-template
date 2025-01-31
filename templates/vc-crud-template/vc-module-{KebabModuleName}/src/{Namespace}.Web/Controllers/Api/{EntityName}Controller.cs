using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using {Namespace}.Core;
using {Namespace}.Core.Models;
using {Namespace}.Core.Services;
using VirtoCommerce.Platform.Core.Common;

namespace {Namespace}.Web.Controllers.Api;

[Route("api/{KebabEntityName}s")]
public class {EntityName}Controller : Controller
{
    private readonly I{EntityName}Service _crudService;
    private readonly I{EntityName}SearchService _searchService;

    public {EntityName}Controller(
        I{EntityName}Service crudService,
        I{EntityName}SearchService searchService)
    {
        _crudService = crudService;
        _searchService = searchService;
    }

    [HttpPost("search")]
    [Authorize(ModuleConstants.Security.Permissions.Read)]
    public async Task<ActionResult<{EntityName}SearchResult>> Search([FromBody] {EntityName}SearchCriteria criteria)
    {
        var result = await _searchService.SearchNoCloneAsync(criteria);
        return Ok(result);
    }

    [HttpPost]
    [Authorize(ModuleConstants.Security.Permissions.Create)]
    public Task<ActionResult<{EntityName}>> Create([FromBody] {EntityName} model)
    {
        model.Id = null;
        return Update(model);
    }

    [HttpPut]
    [Authorize(ModuleConstants.Security.Permissions.Update)]
    public async Task<ActionResult<{EntityName}>> Update([FromBody] {EntityName} model)
    {
        await _crudService.SaveChangesAsync([model]);
        return Ok(model);
    }

    [HttpGet("{id}")]
    [Authorize(ModuleConstants.Security.Permissions.Read)]
    public async Task<ActionResult<{EntityName}>> Get([FromRoute] string id, [FromQuery] string responseGroup = null)
    {
        var model = await _crudService.GetNoCloneAsync(id, responseGroup);
        return Ok(model);
    }

    [HttpDelete]
    [Authorize(ModuleConstants.Security.Permissions.Delete)]
    [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
    public async Task<ActionResult> Delete([FromQuery] string[] ids)
    {
        await _crudService.DeleteAsync(ids);
        return NoContent();
    }
}
