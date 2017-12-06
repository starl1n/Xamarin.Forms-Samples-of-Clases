using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_03
{
	public class Details03 : ContentPage
	{
		public Details03 ()
		{
			Title = "Expandido";
			Content = new StackLayout
			{
			  Margin = new Thickness (0, 20, 0, 0),
			  Children = {
			    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
			    new Label { Text = "StartAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.StartAndExpand },
			    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
			    new Label { Text = "CenterAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.CenterAndExpand },
			    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
			    new Label { Text = "EndAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.EndAndExpand },
			    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
			    new Label { Text = "FillAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
			    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 }
			  }
			};

			//Title = "Alineación";
			//Content = new StackLayout
			//{
			//	Orientation = StackOrientation.Horizontal,
			//  Margin = 50,
			//  Children = {
			    
			//    new Label { Text = "Start", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Start },
			//    new Label { Text = "Center", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Center },
			//    new Label { Text = "End", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.End },
			//    new Label { Text = "Fill", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Fill }
			//  }
			//};
		}
	}
}

