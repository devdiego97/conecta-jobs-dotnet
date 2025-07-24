using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace conecta_jobs_dotnet.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListAllCompanies()
        {
            return Ok("lista de empresas");
        }
    }
}