using System;

using Xamarin.Forms;

namespace XamarinFormsClase04
{
	public class Lugares : ContentPage
	{
		PlaceViewModel viewModel;
		ListView list;
		public Lugares ()
		{

			var databasePath = DependencyService.Get<IFileHelper> ().GetLocalFilePath ("database.db3");
			//Inicializa el view model
			viewModel = new PlaceViewModel (databasePath);


			 list = new ListView ();
			list.ItemsSource = viewModel.Get ();

			//Definiendo el estilo
			var template = new DataTemplate (typeof (ImageCell));
			template.SetBinding (TextCell.TextProperty, "Name");
			template.SetBinding (TextCell.DetailProperty, "FormatedAddress");
			list.ItemTemplate = template;
			Content = list;

			list.ItemTapped += List_ItemTapped;

			Title = "Lugares";
		}

		#region Eventos
		async void List_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			if (Parent != null && Parent is NavigationPage) 
			{
				var parseParent = Parent as NavigationPage;

				await parseParent.PushAsync (new DetalleLugar (e.Item as Place));
			}
		}
		#endregion

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			list.ItemsSource = viewModel.Get ();
		}
	}
}

