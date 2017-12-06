using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_03
{
	public class Details : ContentPage
	{
		public Details ()
		{
			Content = new StackLayout {
				Children = {
					new Label { 
						TextColor = Color.Black,
						Text = "Lorem title" ,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label { 
						TextColor = Color.DarkGray,
						Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " }
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Start
				                               
			};
			Title = "Pagina de Detalle";
			BackgroundColor = Color.GhostWhite;
		}
	}
}

