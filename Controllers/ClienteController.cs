using Microsoft.AspNetCore.Mvc;

namespace ApiIndicadores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Inserir([FromServices] ClienteDAO _dao, Cliente cliente)
        {
            _dao.Inserir(cliente);
            return Ok(cliente);
        }
    }
}