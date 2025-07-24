using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/curriculuns")]
    public class CurriculumController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListAllCurriculuns()
        {
            return Ok("lista de curriculos");
        }
    }
}