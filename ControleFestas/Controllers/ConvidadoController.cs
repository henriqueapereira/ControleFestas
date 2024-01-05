using ControleFestas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFestas.Controllers
{
    public class ConvidadoController : Controller
    {
        public IActionResult Index()
        {
            var convidados = ListarConvidadosMock();
            return View(convidados);
        }

        //Abre a tela p/ cadastrar um novo convidado
        [HttpGet]
        public IActionResult Novo()
        {
            return View(new ConvidadoModel());
        }


        /*---------------------------------------------------------------------*/
        //Cadastra um convidado
        [HttpPost]
        public IActionResult Novo(ConvidadoModel convidadoModel)
        {
            if (string.IsNullOrEmpty(convidadoModel.Nome))
            {
                ViewBag.Mensagem = "O campo nome é requerido";
                return View(convidadoModel);
            }
            else
            {
                TempData["Mensagem"] = $"Convidado {convidadoModel.Nome} cadastrado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }


        /*---------------------------------------------------------------------*/
        //ABRE O EDITAR
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //SELECT * FROM produto WHERE produtoid = id
            var convidado = new ConvidadoModel()
            {
                ConvidadoId = 1,
                Nome = "convidado1",
                Email = "emai1",
                Telefone = 123,
                Idade = 19
            };

            return View(convidado);
        }


        /*---------------------------------------------------------------------*/
        //ENVIA O EDITAR
        [HttpPost]
        public IActionResult Editar(ConvidadoModel convidadoModel)
        {
            if (string.IsNullOrEmpty(convidadoModel.Nome))
            {
                return View(convidadoModel);
            }
            else
            {
                TempData["Mensagem"] = $"Convidado {convidadoModel.Nome} editado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }



        /*---------------------------------------------------------------------*/
        //Simulando o acesso ao banco de dados para obter uma lista de convidados
        private IList<ConvidadoModel> ListarConvidadosMock()
        {
            var convidados = new List<ConvidadoModel>
            {
                new ConvidadoModel { ConvidadoId = 1,Nome = "convidado1", Email = "emai1", Telefone = 123, Idade = 19 },
                new ConvidadoModel { ConvidadoId = 2,Nome = "convidado2", Email = "emai2", Telefone = 124, Idade = 25 }

            };
            return convidados;
        }
    }
}
