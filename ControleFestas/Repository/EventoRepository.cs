using ControleFestas.Data;
using ControleFestas.Models;

namespace ControleFestas.Repository
{
    public class EventoRepository
    {
        //class data context para poder manipular o BD
        private readonly DataContext _dataContext;
        public EventoRepository(DataContext context)
        {
            _dataContext = context;
        }
        

        public IList<EventoModel> FindAll()
        {
            //SELECT * FROM Produtos
            var eventos = _dataContext.Eventos.ToList();
            return eventos == null ? new List<EventoModel>() : eventos;
        }
        /*
        public IList<EventoModel> FindAllWithPromotor()
        {
            return null;
        }

        public int Insert() 
        {
            return null;
        }

        public void Update() 
        {
            
        }

        public void Delete() 
        {
        
        }

        public void Delete(int id) 
        {
        
        }










        */
    }
}
