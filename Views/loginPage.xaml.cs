namespace rfeijooS2.Views;
public partial class loginPage : ContentPage
{
	//vamos a crear variables globales

	string usuar;
	string passw;

	string[] users = { "Carlos", "Ana", "Jose" };
	string[] passwords = { "carlos123", "ana123", "juan123" };
	public loginPage(string usuar1, string passw1)
	{
		InitializeComponent();
		this.usuar = usuar1;
		this.passw = passw1;

		
	}

	private void btnAction_Clicked(object sender, EventArgs e)
	{

		string user = txtUser.Text;
		string password = txtPasswrd.Text;

		bool credentialValid = false;
		for (int i = 0; i < users.Length; i++)
		{
			if (users[i] == user && passwords[i] == password)
			{
				credentialValid = true;
				break;
			}
		}
		if (credentialValid)
		{
			Navigation.PushAsync(new elementsPage(user));
		}
		else
		{
			DisplayAlert("Error", "Usuario/Contraseña incorrectos", "Cerrar");
			txtUser.Text = "";
			txtPasswrd.Text = "";
		}



		//string user = usuar;
		//string password = passw;

		//if (user == txtUser.Text && password == txtPasswrd.Text)
		//{
		//	Navigation.PushAsync(new elementsPage(user));
		//} else
		//{
		//	DisplayAlert("Error", "Usuario/Contraseña incorrectos", "Cerrar");
		//	txtUser.Text = "";
		//	txtPasswrd.Text = "";

		//}
    }

    private void rgtAction_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new registerPage());
    }
}