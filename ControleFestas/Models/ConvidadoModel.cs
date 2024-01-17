using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFestas.Models
{
    [Table("Convidado")]
    public class ConvidadoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConvidadoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }

        [Required]
        public int Telefone { get; set; }

        [Required]
        public int Idade { get; set; }

        //FOREIGN KEY
        public int EventoId { get; set; }
        //NAVIGATION PROPERTY
        [ForeignKey(nameof(EventoId))]
        public EventoModel Evento { get; set; }
    }
}
