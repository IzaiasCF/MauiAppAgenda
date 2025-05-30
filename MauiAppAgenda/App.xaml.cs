using MauiAppAgenda.Models;

namespace MauiAppAgenda
{
    public partial class App : Application
    {
        public List<Evento> lista_evento = new List<Evento>
        {
            new Evento()
            {
                NomeEvento = "Formatura",
                valorUnitario = 300.00
            },
            new Evento()
            {
                NomeEvento = "Debutantes",
                valorUnitario = 150.00
            },
            new Evento()
            {
                NomeEvento = "Excursão",
                valorUnitario = 120.00
            },
            new Evento()
            {
                NomeEvento = "Férias",
                valorUnitario = 1070.00
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 650;

            return window;
        }
    }
}
