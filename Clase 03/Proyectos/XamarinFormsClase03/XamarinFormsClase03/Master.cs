using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
namespace XamarinFormsClase03
{
	public class Master : ContentPage
	{
		ListView list;
		public Master ()
		{
			 list = new ListView ();
			list.BackgroundColor = Color.White;
			list.SeparatorColor = Color.LightSkyBlue;

			list.IsPullToRefreshEnabled = true;
			list.Refreshing+= List_Refreshing;
			list.ItemTapped+= List_ItemTapped;

			list.ItemSelected += (sender, e) => { Debug.WriteLine ("Elemento seleccionado");};
			//list.ItemsSource = new List<String> () {
			//"iOS",
			//	"MacOSX",
			//	"Android",
			//	"Windows"

			//};

			Content = list;
			Title = "Master";
			BackgroundColor = Color.DarkSlateGray;

			list.ItemsSource = TextModel.BindSampleData ();

			 #region textCell
			list.ItemTemplate = new DataTemplate (typeof(TextCell));
			list.ItemTemplate.SetBinding (TextCell.TextProperty, "Title");
			list.ItemTemplate.SetBinding (TextCell.DetailProperty, "Details");
			#endregion

			/*#region imageCell
			list.ItemTemplate = new DataTemplate (typeof(ImageCell));
			list.ItemTemplate.SetBinding (ImageCell.TextProperty, "Title");
			list.ItemTemplate.SetBinding (ImageCell.DetailProperty, "Details");
			list.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");
			#endregion*/

			//#region switchCell
			//list.ItemTemplate = new DataTemplate (typeof(SwitchCell));
			//list.ItemTemplate.SetBinding (SwitchCell.TextProperty, "Title");


			//list.ItemTemplate.SetBinding (SwitchCell.OnProperty, "IsOn");
			//#endregion

			//#region entryCell
			//list.ItemTemplate = new DataTemplate(typeof(EntryCell));
			//list.ItemTemplate.SetBinding(EntryCell.LabelProperty, "Title");
			//list.ItemTemplate.SetBinding(EntryCell.TextProperty, "Details");
			//#endregion                    
		}

		void List_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			
			Debug.WriteLine ("Elemento cliqueado");
			//list.SelectedItem = null;
			if (Parent != null) {
				var parsed = Parent as MasterDetailPage;
				parsed.IsPresented = false;

				if ((e.Item as TextModel).Title == "Controles") {
					parsed.Detail = new NavigationPage (new DetailsControls ());
				} else {
					parsed.Detail = new NavigationPage (new Details (e.Item));
				}
			}
		}

		async void List_Refreshing (object sender, EventArgs e)
		{
			//list.EndRefresh ();
			await DisplayAlert ("Se recibio un pull", "Pull request!", "Ok");
		}
	}

	public class TextModel { 
	
		public string Title { get; set; }
		public string Details { get; set; }
		public bool IsOn { get; set; }
		public string Image { get; set; }

		public static List<TextModel> BindSampleData ()
		{
			var list = new List<TextModel> ();
			list.Add (new TextModel () { Title = "Record 01", Details = "Details 01", IsOn = false });
			list.Add (new TextModel () { Title = "Record 02", Details = "Details 02", IsOn = true });
			list.Add (new TextModel () { Title = "Record 03", Details = "Details 03", IsOn = false });
			list.Add (new TextModel () { Title = "Sin detalle", IsOn = true });
			list.Add (new TextModel () { Title = "Record 05", Details = "Details 05", IsOn = true });
			list.Add (new TextModel () { Title = "Controles",  });

			return list;
		}

	}
}
