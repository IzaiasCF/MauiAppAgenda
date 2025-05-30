namespace MauiAppAgenda.Views;

public partial class Evento : ContentPage
{
	public Evento()
	{
		InitializeComponent();
	}

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