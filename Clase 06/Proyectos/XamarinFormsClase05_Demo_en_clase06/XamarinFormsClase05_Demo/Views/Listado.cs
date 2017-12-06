using System;

using Xamarin.Forms;

namespace XamarinFormsClase05_Demo
{
	public class Listado : ContentPage
	{
		GoogleViewModel viewModel = new GoogleViewModel ();
		Entry busqueda = new Entry { Placeholder = "Busqueda de lugares" };
		ListView list = new ListView ();
		public Listado ()
		{
			viewModel.servicioweb
			         .GetPlaceAutoCompleteResponse += Servicioweb_GetPlaceAutoCompleteResponse;

			busqueda.TextChanged += Busqueda_TextChanged;



			Content = new StackLayout {
				Children = {
					busqueda,
					list
				}
			};
			Title = "Listado de lugares";


			var template = new DataTemplate (typeof(TextCell));
			template.SetBinding (TextCell.TextProperty, "structured_formatting.main_text");
			template.SetBinding (TextCell.DetailProperty, "structured_formatting.secondary_text");
			list.ItemTemplate = template;
		}

		async void Busqueda_TextChanged (object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length > 2) {
				IsBusy = true;
				list.IsRefreshing = true;
				await viewModel.BuscarLugar (e.NewTextValue);
			}
		}

		async void Servicioweb_GetPlaceAutoCompleteResponse (object sender, GoogleMapsPlaceAutocomplete.Results e)
		{
			IsBusy = false;
			list.IsRefreshing = false;
			list.ItemsSource = e.predictions;

		}
	}
}

