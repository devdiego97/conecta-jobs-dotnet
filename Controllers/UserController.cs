using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        
        [HttpGet()]
        public IActionResult ListUsers()
        {
            return Ok("uma string aqui");
        } 
    }
}