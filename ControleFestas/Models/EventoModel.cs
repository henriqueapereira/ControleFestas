namespace ControleFestas.Models
{
    public class EventoModel
    {
        public int EventoId { get; set; }

        public string Titulo { get; set; }

        public string Responsavel { get; set; }

        public string TelefoneResponsavel { get; set; }

        public string Promotor { get; set; }

        public string Cidade { get; set; }

        public DateTime Data { get; set; }

        public DateTime HorarioInicial { get; set; }

        public DateTime HorarioFinal { get; set; }

        public ConvidadoModel Convidado { get; set; }

    }
}
