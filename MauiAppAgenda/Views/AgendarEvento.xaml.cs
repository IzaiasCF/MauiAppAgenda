namespace MauiAppAgenda.Views;

public partial class AgendarEvento : ContentPage
{
	public AgendarEvento()
	{
		InitializeComponent();
	}

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        // Exemplo: exibe no console a nova data selecionada
        DateTime novaData = e.NewDate;
        Console.WriteLine($"Data de início selecionada: {novaData:dd/MM/yyyy}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Evento());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Fechar");
        }
         
    }
}