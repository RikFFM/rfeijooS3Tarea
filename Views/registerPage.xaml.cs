namespace rfeijooS2.Views;

public partial class registerPage : ContentPage
{
	public registerPage()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
		string user = txtnewuser.Text;
		string pass	= txtnewpsswod.Text;

		Navigation.PushAsync(new loginPage(user, pass));	
    }
}