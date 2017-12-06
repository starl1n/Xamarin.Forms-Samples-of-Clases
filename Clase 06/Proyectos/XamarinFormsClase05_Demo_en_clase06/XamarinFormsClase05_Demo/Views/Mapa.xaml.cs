using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Runtime.InteropServices;

namespace XamarinFormsClase05_Demo
{


	public partial class Mapa : ContentPage
	{
		GoogleViewModel viewModel = new GoogleViewModel ();
		Entry busqueda = new Entry { Placeholder = "Busqueda de lugares" };
		Map map;

		double latlongdegrees = 360 / (Math.Pow (2, 15));// 1 - 18

		public Mapa ()
		{
			InitializeComponent ();

			viewModel.servicioweb
			         .GetPlaceAutoCompleteResponse += Servicioweb_GetPlaceAutoCompleteResponse;;

			busqueda.TextChanged += Busqueda_TextChanged;

			 map = new Map ();

			map.MoveToRegion (new MapSpan (
				new Position (18.4539641, -69.9505628), latlongdegrees, latlongdegrees));
			Content =  new StackLayout{

				Children = { 
					busqueda,
					map
				}
			};
		}

		async void Busqueda_TextChanged (object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length > 2) {
				IsBusy = true;
				//list.IsRefreshing = true;
				await viewModel.BuscarLugar (e.NewTextValue);
			}
		}

		async void Servicioweb_GetPlaceAutoCompleteResponse (object sender, GoogleMapsPlaceAutocomplete.Results e)
		{
			IsBusy = false;
			map.MapType = MapType.Street;
			map.Pins.Clear ();// = null;
			foreach (var lugares in e.predictions) {
				var pin = new Pin () {
					Type = PinType.Place,
					Position = new Position (18.4539641, -69.9505628),
					Label = lugares.structured_formatting.main_text,
					Address = lugares.structured_formatting.secondary_text
				};
				pin.Clicked+= Pin_Clicked;
				map.Pins.Add (pin);

				map.MoveToRegion (new MapSpan (
					new Position (18.4539641, -69.9505628), latlongdegrees, latlongdegrees));
			}
		}

		async void Pin_Clicked (object sender, EventArgs e)
		{
			await DisplayAlert("",(sender as Pin).Label, "Ok");
		}
	}
}
