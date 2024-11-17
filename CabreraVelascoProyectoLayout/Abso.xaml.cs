namespace CabreraVelascoProyectoLayout;

public partial class Abso : ContentPage
{
	public Abso()
	{
		InitializeComponent();
	}
    private async void OnNavigateToGridClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Grid());
    }
}