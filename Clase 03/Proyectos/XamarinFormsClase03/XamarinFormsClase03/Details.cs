using System;
using Xamarin.Forms;
namespace XamarinFormsClase03
{
	public class Details : ContentPage
	{
		public Details (Object element)
		{
			Title = "Detalle";

			var layout=new  StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.GhostWhite
			};
			layout.Children.Add (new Label {
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof (Label)),
				TextColor = Color.Black,
				Text = "Details of selected object"
			});

			if (element != null) 
			{
				if (element is string) {
					var parsed = element as string;
					layout.Children.Add (new Label {
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof (Label)),
						TextColor = Color.DimGray,
						Text = parsed
					});
				}
				if (element is TextModel) {
					var parsed = element as TextModel;
					layout.Children.Add (new Label {
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof (Label)),
						TextColor = Color.DimGray,
						Text = parsed.Title
					});
					layout.Children.Add (new Entry {
						FontSize = Device.GetNamedSize (NamedSize.Large, typeof (Entry)),
						TextColor = Color.Blue,
						Text = parsed.Details
					});
				}
			}

			Content = layout;

		}
	}
}
