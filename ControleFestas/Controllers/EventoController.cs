using ControleFestas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFestas.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            var eventos = ListarEventosMock();
            return View(eventos);
        }


        /*---------------------------------------------------------------------*/
        //Abre a tela para cadastrar um novo evento
        [HttpGet]
        public IActionResult Novo()
        {
            return View(new EventoModel());
        }


        /*---------------------------------------------------------------------*/
        //Cadastra um novo evento
        [HttpPost]
        public IActionResult Novo(EventoModel eventoModel)
        {
            if (string.IsNullOrEmpty(eventoModel.Titulo))
            {
                ViewBag.Mensagem = "O campo titulo é requerido";
                return View(eventoModel);
            }
            else
            {
                // INSERT
                return View("Sucesso");
            }
        }


        /*---------------------------------------------------------------------*/
        //ABRE O EDITAR
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //SELECT * FROM produto WHERE produtoid = id
            var evento = new EventoModel()
            {
                EventoId = 1,
                Titulo = "Aniversario 15 anos Bianca",
                Responsavel = "Juliana (mãe)",
                Promotor = "Andreia",
                Cidade = "Piracicaba",
                Data = DateTime.Now,
            };

            return View(evento);
        }


        /*---------------------------------------------------------------------*/
        //ENVIA O EDITAR
        [HttpPost]
        public IActionResult Editar(EventoModel eventoModel)
        {
            if (string.IsNullOrEmpty(eventoModel.Titulo))
            {
                return View(eventoModel);
            }
            else
            {
                TempData["Mensagem"] = $"Evento {eventoModel.Titulo} editado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }

        /*---------------------------------------------------------------------*/
        //Simulando o acesso ao banco de dados para obter uma lista de eventos
        private IList<EventoModel> ListarEventosMock()
        {
            var eventos = new List<EventoModel>
            {
                new EventoModel()
                {
                    EventoId = 1,
                    Titulo = "Aniversario 15 anos Bianca",
                    Responsavel = "Juliana (mãe)",
                    Promotor = "Andreia",
                    Cidade = "Piracicaba",
                    Data = DateTime.Now,

                },
                new EventoModel()
                {
                    EventoId = 2,
                    Titulo = "Casamento Jose e Ana",
                    Responsavel = "Ana",
                    Promotor = "Cristina",
                    Cidade = "Americana",
                    Data = DateTime.Now,

                },
                 new EventoModel()
                {
                    EventoId = 3,
                    Titulo = "Aniversario 25 anos Guilherme",
                    Responsavel = "Guilherme",
                    Promotor = "Jorge",
                    Cidade = "Campinas",
                    Data = DateTime.Now,

                }
            };
            return eventos;
        }
    }
}
