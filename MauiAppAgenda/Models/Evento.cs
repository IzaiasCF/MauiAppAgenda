namespace MauiAppAgenda.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string LocalEvento { get; set; }
        public int NumeroParticipantes { get; set; }
        public double valorUnitario {  get; set; }
        public double valorTotal { get; set; }

    }
}
