using CapaNegocio;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Prueba_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private CD_Usuarios objetoCD=new CD_Usuarios();
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var usuarios = objetoCD.Mostrar();
                String listUsuarios=JsonConvert.SerializeObject(usuarios);
                return Ok(listUsuarios);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
