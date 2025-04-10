using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using {Namespace}.Core.Models;
using {Namespace}.Core.Services;
using VirtoCommerce.Platform.Core.Common;
using Permissions = {Namespace}.Core.ModuleConstants.Security.Permissions;

namespace {Namespace}.Web.Controllers.Api;

[Authorize]
[Route("api/{KebabEntityName}s")]
public class {EntityName}Controller(
    I{EntityName}Service crudService,
    I{EntityName}SearchService searchService)
    : Controller
{
    [HttpPost("search")]
    [Authorize(Permissions.Read)]
    public async Task<ActionResult<{EntityName}SearchResult>> Search([FromBody] {EntityName}SearchCriteria criteria)
    {
        var result = await searchService.SearchNoCloneAsync(criteria);
        return Ok(result);
    }

    [HttpPost]
    [Authorize(Permissions.Create)]
    public Task<ActionResult<{EntityName}>> Create([FromBody] {EntityName} model)
    {
        model.Id = null;
        return Update(model);
    }

    [HttpPut]
    [Authorize(Permissions.Update)]
    public async Task<ActionResult<{EntityName}>> Update([FromBody] {EntityName} model)
    {
        await crudService.SaveChangesAsync([model]);
        return Ok(model);
    }

    [HttpGet("{id}")]
    [Authorize(Permissions.Read)]
    public async Task<ActionResult<{EntityName}>> Get([FromRoute] string id, [FromQuery] string responseGroup = null)
    {
        var model = await crudService.GetNoCloneAsync(id, responseGroup);
        return Ok(model);
    }

    [HttpDelete]
    [Authorize(Permissions.Delete)]
    [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
    public async Task<ActionResult> Delete([FromQuery] string[] ids)
    {
        await crudService.DeleteAsync(ids);
        return NoContent();
    }
}
