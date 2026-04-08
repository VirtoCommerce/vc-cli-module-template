using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Permissions = {Namespace}.Core.ModuleConstants.Security.Permissions;

namespace {Namespace}.Web.Controllers.Api;

[Authorize]
[Route("api/{KebabModuleName}")]
public class {PascalModuleName}Controller : Controller
{
    // GET: api/{KebabModuleName}
    /// <summary>
    /// Get message
    /// </summary>
    /// <remarks>Return "Hello world!" message</remarks>
    [HttpGet]
    [Route("")]
    [Authorize(Permissions.Read)]
    public ActionResult<string> Get()
    {
        return Ok(new { result = "Hello world!" });
    }
}
