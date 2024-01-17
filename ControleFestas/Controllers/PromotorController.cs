using ControleFestas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFestas.Controllers
{
    public class PromotorController : Controller
    {
        //ACESSAR A INDEX DO PROMOTOR
        [HttpGet]
        public IActionResult Index()
        {
            var lista = ObterPromotoresMock();
            return View(lista);
        }


        //Abre a tela para cadastrar um novo evento
        [HttpGet]
        public IActionResult Novo()
        {
            return View(new PromotorModel());
        }


        //ENVIA O CADASTRO DO PRODUTO
        [HttpPost]
        public IActionResult Novo(PromotorModel promotorModel)
        {
            if (string.IsNullOrEmpty(promotorModel.Nome))
            {
                ViewBag.Mensagem = "O campo nome é requerido";
                return View(promotorModel);
            }
            else
            {
                TempData["Mensagem"] = $"Promotor {promotorModel.Nome} cadastrado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }


        //Abre o editar
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //SELECT * FROM produto WHERE produtoid = id
            var promotor = new PromotorModel()
            {
                PromotorId = 1,
                Nome = "João",
                Senha = 123456,
                Email = "joaoemail",
                Telefone = 123456,
            };

            return View(promotor);
        }


        //Envia o editar
        [HttpPost]
        public IActionResult Editar(PromotorModel promotorModel)
        {
            if (string.IsNullOrEmpty(promotorModel.Nome))
            {
                return View(promotorModel);
            }
            else
            {
                TempData["Mensagem"] = $"Promotor {promotorModel.Nome} editado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }


        [HttpPost] //enviar os dados
        public IActionResult Gravar(PromotorModel promotorModel)
        {
            //INSER INTO -- promotorModel

            return View("Sucesso");
        }


        //Simulando o acesso ao banco de dados para obter uma lista de promotores
        private IList<PromotorModel> ObterPromotoresMock()
        {
            // SELECT * FROM produtos;

            var promotores = new List<PromotorModel>
            {
                new PromotorModel()
                {
                    PromotorId = 1,
                    Nome = "João",
                    Senha = 123456,
                    Email = "joaoemail",
                    Telefone = 123456,
                },
            };

            return promotores;
        }
    }
}
