using _2DNPJ1092024.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _2DNPJ1092024.Controllers

{
    [Route("api/[controller]")]
    [ApiController]


    public class DocentesController : ControllerBase
    {
        static List<Docente> docentes = new List<Docente>();

        [HttpGet]

        public IEnumerable<Docente> Get()
        {
            return docentes;
        }

        [HttpGet("{id}")]

        public Docente Get(int id)
        {
            var docente = docentes.FirstOrDefault(c => c.Id == id);
            return docente;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Docente docente)
        {
            docentes.Add(docente);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Docente docente)
        {
            var existingDocente = docentes.FirstOrDefault(c => c.Id == id);
            if (existingDocente != null)
            {
                existingDocente.Nombre = docente.Nombre;
                existingDocente.Apellido = docente.Apellido;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var  existingDocente = docentes.FirstOrDefault(c => c.Id == id);
            if (existingDocente != null)
            {
                docentes.Remove(existingDocente);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}

