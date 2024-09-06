using Microsoft.AspNetCore.Mvc;

namespace lez12_api_test.Controllers
{
    [Route("api/saluta")]
    public class TestController : Controller
    {

        [HttpGet("giovanni")]
        public IActionResult SalutaGiovanni()
        {
            return Ok("CIAO GIOVANNI");
        }

        [HttpGet("antonio")]
        public IActionResult SalutaAntonio()
        {
            return Ok("CIAO ANTONIO");
        }

        [HttpGet("personalizzato/{nome}/{cognome}")]
        public IActionResult SalutaPersonalizzato(string nome, string cognome)
        {
            return Ok($"Ciao {nome} {cognome}");
        }
    }
}
