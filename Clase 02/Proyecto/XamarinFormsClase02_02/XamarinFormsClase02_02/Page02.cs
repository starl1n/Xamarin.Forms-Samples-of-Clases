using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_02
{
	public class Page02 : ContentPage
	{
		public Page02 ()
		{
			var button = new Button ();
			button.Text = "Ir a la pagina de detalle";
			button.Clicked += Button_Clicked;
			Title = "Page 02";
			Icon = "ic_backup_black_24dp";
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
					button
					}
			};
		}

		async void Button_Clicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page03 ());
		}
	}
}

