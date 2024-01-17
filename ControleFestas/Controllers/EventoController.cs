using ControleFestas.Data;
using ControleFestas.Models;
using ControleFestas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleFestas.Controllers
{
    public class EventoController : Controller
    {
        //criar os métodos para poder acessar o eventoRepository
        private readonly EventoRepository _eventoRepository;

        public EventoController(DataContext dataContext)
        {
            _eventoRepository = new EventoRepository(dataContext);
        }

        //INDEX - Mostra todos os eventos cadastrados
        public IActionResult Index()
        {
            var eventos = _eventoRepository.FindAll();
            return View(eventos);
        }


        //Abre a tela para cadastrar um novo evento
        [HttpGet]
        public IActionResult Novo()
        {
            return View(new EventoModel());
        }


        //Envia o Cadastra um novo evento
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
                TempData["Mensagem"] = $"Evento {eventoModel.Titulo} cadastrado com sucesso";
                // INSERT
                return RedirectToAction("Index");
            }
        }


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
                //Promotor = "Andreia",
                Cidade = "Piracicaba",
                Data = DateTime.Now,
            };

            return View(evento);
        }


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

        //Abre o detalhe
        /*
         [HttpGet]
        public IActionResult Detalhe(int id)
        {
            //SELECT * FROM produto WHERE produtoid = id
            EventoModel evento = _eventoRepository.FindById(id);
            return View(evento);
        }
        */
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
                   // Promotor = "Andreia",
                    Cidade = "Piracicaba",
                    Data = DateTime.Now,

                },
                new EventoModel()
                {
                    EventoId = 2,
                    Titulo = "Casamento Jose e Ana",
                    Responsavel = "Ana",
                    //Promotor = "Cristina",
                    Cidade = "Americana",
                    Data = DateTime.Now,

                },
                 new EventoModel()
                {
                    EventoId = 3,
                    Titulo = "Aniversario 25 anos Guilherme",
                    Responsavel = "Guilherme",
                    //Promotor = "Jorge",
                    Cidade = "Campinas",
                    Data = DateTime.Now,

                }
            };
            return eventos;
        }
    }
}
