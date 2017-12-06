using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsClase06
{
	public partial class Formulario : ContentPage
	{
		public Formulario ()
		{
			InitializeComponent ();


			btnGuardar.Clicked += BtnGuardar_Clicked;
			contenedor.Children.Add (new Editor ());
		}

		async void BtnGuardar_Clicked (object sender, EventArgs e)
		{
			await DisplayAlert ("Success", "Click en guardar", "Ok");
		}
	}
}
