using ControleFestas.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFestas.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ConvidadoModel> Convidados { get; set; }
        public DbSet<EventoModel> Eventos { get; set; }
        public DbSet<PromotorModel> Promotores { get; set; }
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected DataContext()
        {
        }
    }
}
