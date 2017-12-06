using System;

using Xamarin.Forms;

namespace XamarinFormsClass04_demo
{
	public class ListadoDeLugares : ContentPage
	{
		LugarViewModel viewModel;
		ListView list = new ListView ();
		public ListadoDeLugares ()
		{
			string databasePath = DependencyService.Get<IFileHelper> ().DatabasePath ("database.db");
			viewModel = new LugarViewModel (databasePath);

			var template = new DataTemplate (typeof (TextCell));
			template.SetBinding (TextCell.TextProperty, "Title");
			template.SetBinding (TextCell.DetailProperty, "Address");
			template.SetValue (TextCell.TextColorProperty, Color.Green);
			list.ItemTemplate = template;
			list.ItemsSource = viewModel.Lugares();
			list.ItemTapped+= List_ItemTapped;

			//Global page
			Title = "Listado";
			Content = list;
		}

		async void List_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			await Navigation.PushAsync (new DetalleLugar (e.Item as Lugar));
		}


		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			list.ItemsSource = viewModel.Lugares();
		}
	}
}

