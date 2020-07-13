using RichEditClientBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RichEditClientBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RichEditController : ControllerBase
    {
        [HttpPost]
        [Route("SaveDocument")]
        public IActionResult SaveDocument([FromForm] string base64, [FromForm] string fileName, [FromForm] int format, [FromForm] string reason)
        {
            byte[] fileContents = System.Convert.FromBase64String(base64);
            return Ok();
        }
    }
}
