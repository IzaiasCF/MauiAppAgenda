namespace MauiAppAgenda.Models
{
    public class Evento
    {
        internal double valorUnitario;

        public string NomeEvento { get; set; }
        public string LocalEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public double ValorUnitario {  get; set; }

        public int EventoSelecionado
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                double Custo_Participante = NumeroParticipantes * ValorUnitario;

                return Custo_Participante;

            }
        }

    }
}
