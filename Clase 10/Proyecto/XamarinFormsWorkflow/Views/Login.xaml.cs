using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsWorkflow
{
	public partial class Login : ContentPage
	{
		AccountViewModel viewModel;

		public Login ()
		{
			InitializeComponent ();
			var dbPath = DependencyService.Get<iRutaDB> ().Ruta ("database.db");
			viewModel = new AccountViewModel (dbPath );

			btnIngresar.Clicked += BtnIngresar_Clicked;
		}

		async void BtnIngresar_Clicked (object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace (Username.Text) &&
			   !string.IsNullOrWhiteSpace (Password.Text)) {
				var canLogin = viewModel.CanLogIn (Username.Text, Password.Text);

				if (canLogin) {
					
				} else {
					await DisplayAlert ("Error", "Usuario o clave incorrecto", "Ok");
				}

			} else {

				await DisplayAlert ("Error", "Usuario o clave incompleto", "Ok");
			}
		}
	}
}
