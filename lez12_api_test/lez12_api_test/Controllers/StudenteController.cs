using lez12_api_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace lez12_api_test.Controllers
{
    [ApiController]
    [Route("Studente")]
    public class StudenteController : Controller
    {
        private static List<Studente> lista = new List<Studente>()
        {
            new Studente(){ Id = 1, Nome = "Giovanni", Cognome = "Pace", Matricola = "AB1234"},
            new Studente(){ Id = 2, Nome = "Valeria", Cognome = "Verdi", Matricola = "AB1235"},
        };

        [HttpGet]
        public IActionResult findAll()
        {
            return Ok(lista);
        }

        [HttpGet("{varMatricola}")]
        public IActionResult find(string varMatricola)
        {
            foreach (var studente in lista)
                if(studente.Matricola == varMatricola)
                    return Ok(studente);

            return BadRequest();
        }

        [HttpPost]
        public IActionResult insert(Studente objStu)
        {
            lista.Add(objStu);
            return Ok();
        }

    }
}
