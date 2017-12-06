using System;

using Xamarin.Forms;

namespace XamarinFormsClase02
{
	public class Pagina02 : ContentPage
	{
		public Pagina02 ()
		{
			var button = new Button ();
			button.Text = "Ir a página 03";
			button.Clicked += Button_Clicked;


			var buttonBack = new Button ();
			buttonBack.Text = "Volver a página 1 (Pop)";

			buttonBack.Clicked += ButtonBack_Clicked;
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage 02" },
					button,
					buttonBack
				},
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions= LayoutOptions.Center,


			};
			Title = "Página 02";
		}

		async void Button_Clicked (object sender, EventArgs e)
		{
			var pagina03 = new Pagina03 ( "Data Credito");
			await Navigation.PushAsync (pagina03);
		}

		async void ButtonBack_Clicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync (true);
		}
	}
}

