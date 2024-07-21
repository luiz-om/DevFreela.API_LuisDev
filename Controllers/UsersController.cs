using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        //Post /api/users
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        // PUT api/users/id/profile-picture
        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file)
        {

            var description = $"File: {file.FileName}, Tamanho: {file.Length}";

            //Processar a imagem

            return Ok(description);
        }
    }
}