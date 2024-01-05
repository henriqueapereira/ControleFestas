using ControleFestas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFestas.Controllers
{
    public class PromotorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //enviar os dados
        public IActionResult Gravar(PromotorModel promotorModel)
        {
            //INSER INTO -- promotorModel

            return View("Sucesso");
        }
    }
}
