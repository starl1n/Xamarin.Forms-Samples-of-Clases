using Xamarin.Forms;
using System.IO;

namespace XamarinFormClase08
{
	public partial class XamarinFormClase08Page : ContentPage
	{
		public XamarinFormClase08Page ()
		{
			InitializeComponent ();

			Button pickPictureButton = new Button {
				Text = "Pick Photo",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			stack.Children.Add(pickPictureButton);

			pickPictureButton.Clicked += async (sender, e) => {
				var streamimg =  await DependencyService.Get<IPickerInterface> ().GetImageStream ();
				if (streamimg != null) 
				{
					var img = new Image {
						Source = ImageSource.FromStream (() => streamimg),
						BackgroundColor = Color.Red

					};

					stack.Children.Add (img);
				}
			};
		}
	}
}
