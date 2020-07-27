using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiIndicadores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndicadoresController : ControllerBase
    {
        [HttpGet("{id}")]
        public Indicador Get([FromServices] IndicadoresDAO _dao, string id)
        {
            return _dao.Obter(id);
        }
    }
}
