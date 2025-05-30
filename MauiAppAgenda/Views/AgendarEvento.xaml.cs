namespace MauiAppAgenda.Views;

public partial class AgendarEvento : ContentPage
{

    App PropriedadesApp;
    private object pck_local;
    private object pck_local_evento;

    public AgendarEvento()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_evento.ItemsSource = PropriedadesApp.lista_evento;

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(1);
	}

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime novaData = e.NewDate;
        Console.WriteLine($"Data de início selecionada: {novaData:dd/MM/yyyy}");
    }

    private string GetTxt_local(string txt_local)
    {
        return txt_local;
    }

    private async void Button_Clicked(object sender, EventArgs e, string txt_local)
    {
        try
        {
            Evento h = new Evento
            {
                NomeEvento = (string)pck_evento.SelectedItem,
                LocalEvento = (string)txt_local,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                NumeroParticipantes = Convert.ToInt16(stp_pessoas),
            };

            await Navigation.PushAsync(new Evento()
            {
                BindingContext = h
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops!", ex.Message, "Fechar");
        }
         
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        NavigationPage Evento;
    }
}