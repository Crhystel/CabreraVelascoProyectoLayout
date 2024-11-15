namespace CabreraVelascoProyectoLayout
{
    public partial class Grid : ContentPage
    {
        int count = 0;

        public Grid()
        {
            InitializeComponent();
        }

        private void Boton1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stack());

        }
    }

}
