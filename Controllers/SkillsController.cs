using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        // Get api/skills
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post(CreateSkillInputModel model)
        {
            return Ok();
        }

    }
}