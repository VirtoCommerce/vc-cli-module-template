using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using {Namespace}.Core;

namespace {Namespace}.Web.Controllers.Api
{
    [Route("api/{KebabModuleName}")]
    public class {ModuleName}Controller : Controller
    {
        // GET: api/{KebabModuleName}
        /// <summary>
        /// Get message
        /// </summary>
        /// <remarks>Return "Hello world!" message</remarks>
        [HttpGet]
        [Route("")]
        [Authorize(ModuleConstants.Security.Permissions.Read)]
        public ActionResult<string> Get()
        {
            return Ok(new { result = "Hello world!" });
        }
    }
}
