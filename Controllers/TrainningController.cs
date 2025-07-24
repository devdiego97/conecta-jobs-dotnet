using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/trainnings")]
    public class TrainningController : ControllerBase
    {
        public IActionResult ListAllTrainnings()
        {
            return Ok("lista de cursos");
        }
        
    }
}