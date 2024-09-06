using lez13_api_db.DAL;
using lez13_api_db.Models;
using Microsoft.AspNetCore.Mvc;

namespace lez13_api_db.Controllers
{
    [ApiController]
    [Route("prodotto")]
    public class ProdottoController : Controller
    {
        [HttpGet]
        public IActionResult Elenca()
        {
            List<Prodotto> lista = ProdottoDAL.getInstance().GetAll();
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult Inserisci(Prodotto objProd)
        {
            if (ProdottoDAL.getInstance().Insert(objProd))
                return Ok();

            return BadRequest();    
        }
    }
}
