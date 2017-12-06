using System;

using Xamarin.Forms;

namespace XamarinFormsClase02
{
	public class Pagina01 : ContentPage
	{
		public Pagina01 ()
		{
			var button = new Button () { 
				Text = "Ir a página 2" ,
				BackgroundColor = Color.Black,
				TextColor = Color.White
			};
			button.Clicked += Button_Clicked;


			Content = new StackLayout {
				BackgroundColor = Color.Blue,
				Children = {
					new Label { Text = "Hello ContentPage 01" , TextColor = Color.White},
					button


				}
			};

			Title = "Página 01";
		}

		async void Button_Clicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Pagina02 ());
		}
	}
}

