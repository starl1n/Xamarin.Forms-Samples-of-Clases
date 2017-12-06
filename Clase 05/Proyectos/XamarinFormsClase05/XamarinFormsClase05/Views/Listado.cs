using System;

using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace XamarinFormsClase05
{
	public class Listado : ContentPage
	{
		List<XamarinFormsClase05.GoogleMapsPlaceAutocomplete.Prediction> Data = new List<GoogleMapsPlaceAutocomplete.Prediction> ();
		Entry Busqueda = new Entry {
			Placeholder = "Nombre de un sitio"

		};
		ListView list = new ListView ();

		GoogleMapsViewModel viewModel;

		public Listado ()
		{
			viewModel = new GoogleMapsViewModel ();
			viewModel.PlaceAutoCompleteResponse += ViewModel_PlaceAutoCompleteResponse;

			//List view design
			list.BackgroundColor = Color.Crimson;
			list.ItemTemplate = new DataTemplate (typeof(TextCell));
			list.ItemTemplate.SetValue (TextCell.TextColorProperty, Color.White);
			list.ItemTemplate.SetBinding (TextCell.TextProperty, "structured_formatting.main_text");


			list.ItemTemplate.SetBinding (TextCell.DetailProperty, "structured_formatting.secondary_text");
			list.ItemTemplate.SetValue (TextCell.DetailColorProperty, Color.LightGray);

			Busqueda.TextChanged += Busqueda_TextChanged;


			Content = new StackLayout {
				Children = {
					Busqueda,
					list
				}
			};

			Title = "Google Place Search";
		}

		async void Busqueda_TextChanged (object sender, TextChangedEventArgs e)
		{
			try {
				if (e.NewTextValue.Length > 2) {
					IsBusy = true;
					list.IsRefreshing = true;
					//if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected) {
						await viewModel.PlaceAutoComplete (e.NewTextValue);
					
				}
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
		}

		void ViewModel_PlaceAutoCompleteResponse (object sender, System.Collections.Generic.List<XamarinFormsClase05.GoogleMapsPlaceAutocomplete.Prediction> e)
		{
			Data = e;
			BindData ();
		}

		void BindData ()
		{
			if (Data != null) {
				Device.BeginInvokeOnMainThread (() => {
					IsBusy = false;
					list.IsRefreshing = false;
					list.ItemsSource = Data;
				});
			}
		}
	}
}

