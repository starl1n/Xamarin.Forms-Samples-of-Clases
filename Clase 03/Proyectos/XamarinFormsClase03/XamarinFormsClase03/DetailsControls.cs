using System;

using Xamarin.Forms;

namespace XamarinFormsClase03
{
	public class DetailsControls : ContentPage
	{
		public DetailsControls ()
		{
			BackgroundColor = Color.LightGray;
			#region Entry
			var textbox = new Entry ();
			textbox.Placeholder = "Textbox";
			#endregion
			#region Button
			var btn = new Button ();
			btn.Text = "Boton";
			btn.Clicked += (sender, e) => {
				btn.Text = "Clickeado a las " + DateTime.Now;
			};
			#endregion
			#region DatePicker
			var dpicker = new DatePicker ();
			dpicker.DateSelected += (sender, e) => {
				textbox.Text = e.NewDate.ToString();
			
			};

			#endregion

			#region Picker
			var picker = new Picker ();
			picker.Items.Add ("Manzana");
			picker.Items.Add ("Pera");
			picker.Items.Add ("Limon");
			picker.SelectedIndexChanged+= (sender, e) => {
				textbox.Text = picker.SelectedItem.ToString();
			
			};
			#endregion

			#region InsideStackLayout
			var stack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
			
			};
			stack.Children.Add (new Label { Text = "Nombre" , 
				HorizontalOptions = LayoutOptions.StartAndExpand,
			
				VerticalOptions = LayoutOptions.CenterAndExpand
			});
			stack.Children.Add (new Entry { Placeholder = "Primer nombre", 
				HorizontalOptions = LayoutOptions.EndAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			});
			#endregion

			#region WebView
			var web = new WebView () {

				Source = "https://google.com",
				HeightRequest = 500,
			};

			#endregion
			#region WebView
			var webLocalSource = new WebView () { 
			HeightRequest = 900,
				BackgroundColor = Color.Yellow
			};
			webLocalSource.Source = new HtmlWebViewSource () {
				Html = "<h2>Data Crédito</h2><br/><p>Curso Xamarin.Forms</p><p>/Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/XamarinFormsClase03.iOS.exe\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/Xamarin.Forms.Platform.iOS.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/Xamarin.Forms.Core.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Runtime.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.ObjectModel.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Core.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Xml.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/Mono.Dynamic.Interpreter.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.ComponentModel.Composition.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Collections.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Diagnostics.Debug.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Threading.Tasks.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Globalization.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.ComponentModel.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Xml.ReaderWriter.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Reflection.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Linq.Expressions.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.IO.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Dynamic.Runtime.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Threading.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/Xamarin.Forms.Platform.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Runtime.Extensions.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Linq.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Reflection.Extensions.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Net.Http.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.Runtime.Serialization.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/System.ServiceModel.Internals.dll [External]\nLoaded assembly: /Users/starlingonzalez/Library/Developer/CoreSimulator/Devices/E96892F1-8FE5-4A1C-A8BD-7896B13B5A2C/data/Containers/Bundle/Application/26F05430-6E68-41D9-8453-91F77B28E73F/XamarinFormsClase03.iOS.app/XamarinFormsClase03.dll\nLoaded assembly: /Library/Frameworks/Xamarin.Interactive.framework/Versions/Current/Agents/Forms/iOS/Xamarin.Interactive.iOS.dll [External]\nLoaded assembly: /Library/Frameworks/Xamarin.Interactive.framework/Versions/Current/Agents/Forms/iOS/Xamarin.Interactive.dll [External]</p>",

			};

			#endregion

			Content = new ScrollView{

				Content = new StackLayout {
					Margin = 50,
					Children = {
						new Label { Text = "Hello label" },
						textbox,
						btn,
						dpicker,
						picker,
						stack,
					web,
					webLocalSource
					}
				}
			};
		}
	}
}

