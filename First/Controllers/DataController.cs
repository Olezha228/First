using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new { Name = "John", Age = 30 };
            return Ok(data);
        }
    }
}
