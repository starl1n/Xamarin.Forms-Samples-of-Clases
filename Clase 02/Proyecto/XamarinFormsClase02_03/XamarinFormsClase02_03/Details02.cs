using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_03
{
	public class Details02 : ContentPage
	{
		public Details02 ()
		{
			var img = "";
			switch (Device.RuntimePlatform) {
			case Device.iOS :
				img = "18194633_10155116910866605_6268378657792773710_n.jpg";
				break;
				case Device.Android:
				img = "img_18194633_10155116910866605_6268378657792773710_n.jpg";
				break;
			}
			Content = new StackLayout {
				Padding = 50,
				Children = {
					
					new Image (){ Source = ImageSource.FromFile(img)},
					new Label { Text = "Meme desde el dispositivo.", FontAttributes = FontAttributes.Bold }
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
				                               
			};
			Title = "Pagina de Detalle 02";
			BackgroundColor = Color.LightSlateGray;
		}
	}
}

