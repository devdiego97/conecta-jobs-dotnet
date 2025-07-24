using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/skills")]
    public class SkillController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListAlSkills()
        {
            return Ok("lista de habilidades");
        }
        
    }
}