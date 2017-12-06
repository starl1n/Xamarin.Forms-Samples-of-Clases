using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PLAN;

namespace XamarinFormsClase05
{
	public class GoogleMapsViewModel
	{
		public AppWebService service = new AppWebService ();
		public static string PlacePhotos = "https://maps.googleapis.com/maps/api/place/photo?maxwidth={0}&photoreference={1}&key={2}";

		public event EventHandler<List<GoogleMapsPlaceAutocomplete.Prediction>> PlaceAutoCompleteResponse;
		public async Task PlaceAutoComplete (string search)
		{

			var query = "input=" + search + "&types=establishment" + "&key=" + service.GoogleMapsKey;
			var response = await service.GetActions<GoogleMapsPlaceAutocomplete.Results> ("place", "/autocomplete/json", query, service.CreateClientGoogleMaps ());

			if (PlaceAutoCompleteResponse != null) {
				PlaceAutoCompleteResponse (this, response.predictions);
			}
		}
public event EventHandler<List<GoogleMapsPlaceAutocomplete.Prediction>> PlaceAutoCompleteResponseWithoutWait;
		
		public async void PlaceAutoCompleteWithoutWait (string search)
		{

			var query = "input=" + search + "&types=establishment" + "&key=" + service.GoogleMapsKey;
			var response = await service.GetActions<GoogleMapsPlaceAutocomplete.Results> ("place", "/autocomplete/json", query, service.CreateClientGoogleMaps ());

			if (PlaceAutoCompleteResponseWithoutWait != null) {
PlaceAutoCompleteResponseWithoutWait (this, response.predictions);
			}
		}

		public event EventHandler<GoogleMapsPlaceDetails.Item> PlaceDetailsResponse;
		public async Task PlaceDetails (string PlaceID)
		{

			var query = "placeid=" + PlaceID + "" + "&key=" + service.GoogleMapsKey;
			var response = await service.GetActions<GoogleMapsPlaceDetails.Item> ("place", "/details/json", query, service.CreateClientGoogleMaps ());

			if (PlaceDetailsResponse != null) {
				PlaceDetailsResponse (this, response);
			}
		}

	}
}
