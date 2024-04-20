

namespace rfeijooS2.Views;

public partial class elementsPage : ContentPage
{
	public elementsPage(string user)
	{
		InitializeComponent();
		DisplayAlert("Bienvenido " , user, "Aceptar");
		lbluser.Text = "Usuario conectado " + user; 
	}

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
		if(pkCiudad.SelectedIndex == -1)
		{
			DisplayAlert("Alerta", "Seleccione un país", "Cerrar");

        }
		string data = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
		//DisplayAlert("Hola", "La ciudad escogida es: " + data , "close");
		lbDato.Text = "La ciudad escogida es: "+data;
    }

    private void btonDate_Clicked(object sender, EventArgs e)
    {
        string date = dpDate.Date.ToString();
		lbDato.Text = "La fecha escogida es: " + date;
    }

    private void btnclossn_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}