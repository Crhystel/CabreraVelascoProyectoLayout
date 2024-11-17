namespace CabreraVelascoProyectoLayout;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}
    private void Boton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Abso());
    }

    private void Boton1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Abso());
    }

    private void Boton3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Abso());
    }
}