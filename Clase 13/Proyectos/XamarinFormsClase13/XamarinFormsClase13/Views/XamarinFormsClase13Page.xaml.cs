using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinFormsClase13
{
	public partial class XamarinFormsClase13Page : ContentPage
	{

		CreditoViewModel viewModel;

		public XamarinFormsClase13Page ()
		{
			InitializeComponent ();



			viewModel = new CreditoViewModel ();
			viewModel.LoginResponse+= ViewModel_LoginResponse;
			viewModel.ExpedientesResponse += ViewModel_ExpedientesResponse;
			btnLogin.Clicked += BtnLogin_Clicked;

		}

		async void BtnLogin_Clicked (object sender, System.EventArgs e)
		{
			await viewModel.Login (username.Text, password.Text);

		}

		async void ViewModel_LoginResponse (object sender, string e)
		{
			if (!e.Contains ("-")) {
				await DisplayAlert ("Error", e, "Ok");
				return;
			} else {
				//Pasar siguiente pantalla
				await viewModel.Expedientes (e,1);
			}
		}

		void ViewModel_ExpedientesResponse (object sender, System.Collections.Generic.List<XamarinFormsClase13.Expediente> e)
		{
			listado.ItemsSource = e;
		}
	}
}
