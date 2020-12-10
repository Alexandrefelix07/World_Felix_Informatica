using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using World_Felix_Informatica.BLL.Models;
using World_Felix_Informatica.DAL.Class;

namespace World_Felix_Informatica.Controllers
{

    [ApiController]
    [Route("v1/Usuarios")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Usuario>>> Get([FromServices] DalBase dal)
        {
            var usuarios = await dal.Usuarios.ToListAsync();
            return usuarios;
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuario>> Post([FromServices] DalBase dal,[FromBody]Usuario model)
        {
            if (ModelState.IsValid) {
                dal.Usuarios.Add(model);
                await dal.SaveChangesAsync();
                return model;                          
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }


  
}
