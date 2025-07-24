using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/jobs")]
    public class JobController : ControllerBase
    {

        [HttpGet]
        public IActionResult ListAllJobs()
        {
            return Ok("lista de jobs");
        }
    }
}