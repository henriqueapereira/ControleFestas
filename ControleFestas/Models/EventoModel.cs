using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ControleFestas.Models
{
    [Table("Evento")]
    public class EventoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventoId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(20)]
        public string Responsavel { get; set; }

        [Required]
        public string TelefoneResponsavel { get; set; }


        [Required]
        public string Cidade { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public DateTime HorarioInicial { get; set; }

        [Required]
        public DateTime HorarioFinal { get; set; }

        //FOREIGN KEY
        public int PromotorId { get; set; }
        //NAVIGATION PROPERTY
        [ForeignKey(nameof(PromotorId))]
        public PromotorModel Promotor { get; set; }
        //
        
        

    }
}
