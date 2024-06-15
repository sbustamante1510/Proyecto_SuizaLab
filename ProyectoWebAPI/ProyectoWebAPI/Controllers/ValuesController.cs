using Microsoft.AspNetCore.Mvc;
using ProyectoWebAPI.Data;
using ProyectoWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>

        [HttpGet]
        public List<Cita> Get()
        {
            return CitaData.Listar();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Cita Get(int id)
        {
            return CitaData.Obtener(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public bool Post([FromBody] Cita oUsuario)
        {
            return CitaData.Registrar(oUsuario);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] Cita oUsuario)
        {
            return CitaData.Modificar(oUsuario);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return CitaData.Eliminar(id);
        }
    }
}
