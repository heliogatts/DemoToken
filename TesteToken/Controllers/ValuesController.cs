using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TesteToken.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [Authorize("Bearer")]
        [HttpGet()]
        public IActionResult Get()
        {
            var objeto = new
            {
                AlturaMetros = Math.Round(30 * 0.3048, 4)
            };

            return Ok(objeto);
        }

    }
}
