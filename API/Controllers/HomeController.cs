using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var host = HttpContext.Request.Host.Value;

            return Ok(host);
        }

        [HttpGet("hc")]
        public IActionResult hc()
        {
            var json = JsonSerializer.Serialize(new
            {
                message = "Healthy",
                time = DateTime.Now
            });

            return Ok(json);
        }
    }
}
