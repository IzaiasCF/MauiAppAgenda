namespace MauiAppAgenda
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Title = string.Empty; // Remove o "Home"
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AgendarEvento());
        }
    }

}
