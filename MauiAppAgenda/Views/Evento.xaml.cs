namespace MauiAppAgenda.Views;

public partial class Evento : ContentPage
{
	public Evento()
	{
		InitializeComponent();
	}

    public string LocalEvento { get; internal set; }
    public string NomeEvento { get; internal set; }
    public DateTime DataInicio { get; internal set; }
    public DateTime DataTermino { get; internal set; }
    public short NumeroParticipantes { get; internal set; }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "Ok");
		}
    }
}