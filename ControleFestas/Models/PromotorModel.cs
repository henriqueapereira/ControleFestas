using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFestas.Models
{
    [Table("Promotor")]
    public class PromotorModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PromotorId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Senha { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

       

    }
}
