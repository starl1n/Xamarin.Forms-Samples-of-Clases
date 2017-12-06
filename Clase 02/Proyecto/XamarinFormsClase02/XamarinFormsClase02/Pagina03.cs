using System;

using Xamarin.Forms;
using System.Threading;
using System.Diagnostics;

namespace XamarinFormsClase02
{
	public class Pagina03 : ContentPage
	{
		public Pagina03 (string newstring)
		{
			var button = new Button ();
			button.Text = "Volver al inicio";
			button.Clicked += Button_Clicked;

			var labelFromPage2 = new Label ();
			labelFromPage2.Text = newstring;

			BackgroundColor = Color.Aqua;
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage 03" },
					button,
					labelFromPage2
				},
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions= LayoutOptions.Center

			};
			Title = "Página 03";


		}

		void Button_Clicked (object sender, EventArgs e)
		{
			Navigation.PopToRootAsync (true);
		}
	}
}

