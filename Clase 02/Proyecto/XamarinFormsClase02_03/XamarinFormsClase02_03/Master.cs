using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_03
{
	public class Master : ContentPage
	{
		public Master ()
		{
			var button = new Button ();
			button.Text = "Pagina 01";
			button.Clicked += Button_Clicked;

			var buttonPage2 = new Button ();
			buttonPage2.Text = "Pagina 02";
			buttonPage2.Clicked += buttonPage2_Clicked;

			var buttonPage3 = new Button ();
			buttonPage3.Text = "Pagina 03";
						buttonPage3.Clicked += buttonPage3_Clicked;


			Title = "Master";
			Content = new StackLayout {
				Children = {
					new Label { Text = "Menu" , TextColor = Color.White},
					button,
					buttonPage2,
					buttonPage3
				}
				,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			BackgroundColor = Color.DarkBlue;

		}

		 void Button_Clicked (object sender, EventArgs e)
		{
			if (Parent != null) {
				var parsed = Parent as MasterDetailPage;
				parsed.Detail = new NavigationPage (new Details ());
				parsed.IsPresented = false;//Oculta el master
			}
		}

		 void buttonPage2_Clicked (object sender, EventArgs e)
		{
			if (Parent != null) {
				var parsed = Parent as MasterDetailPage;
				parsed.Detail = new NavigationPage (new Details02 ());

				parsed.IsPresented = false;//Oculta el master
			}
		}
void buttonPage3_Clicked (object sender, EventArgs e)
{
	if (Parent != null) {
		var parsed = Parent as MasterDetailPage;
		parsed.Detail = new NavigationPage (new Details03 ());

		parsed.IsPresented = false;//Oculta el master
	}
		}
	}
}

