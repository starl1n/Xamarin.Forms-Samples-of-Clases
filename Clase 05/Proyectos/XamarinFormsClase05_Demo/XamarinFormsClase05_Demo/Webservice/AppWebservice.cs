using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace XamarinFormsClase05_Demo
{
	public class AppWebservice
	{
		//Ejemplo URL
//https://maps.googleapis.com/maps/api/place/textsearch/json?query=hilton&types=lodging&key=AIzaSyC_SwjpcVp2fMr-Elbzakzo_FU_O_8koHc
		public string GoogleMapDefaultPath = "https://maps.googleapis.com/maps/api/";
		public string GoogleMapsKey = "AIzaSyBNOcv8pK3JobWJhDGyLZwVNUwJleCOCQs";

		public AppWebservice ()
		{
		}

		public HttpClient CrearClient ()
		{
			HttpClient client = null;
			try {
				client = new HttpClient ();
				client.BaseAddress = new Uri (GoogleMapDefaultPath);
				client.DefaultRequestHeaders.Accept
				      .Add ((MediaTypeWithQualityHeaderValue)MediaTypeHeaderValue
				            .Parse ("application/json"));
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}

			return client;
		}

public event EventHandler<GoogleMapsPlaceAutocomplete.Results> GetPlaceAutoCompleteResponse;

		public async Task Get (string ParametroPrincipal, 
		                       string Metodo, 
		                       string query)
		{
			using (var cliente = CrearClient ()) 
			{
				string Search = ParametroPrincipal + "/" +
								Metodo + "?" +
					"input="+query+"&types=establishment&key=" + GoogleMapsKey;


				var response = await cliente
					.GetAsync (Search,HttpCompletionOption.ResponseContentRead);
				
				var contenido = await response.Content.ReadAsStringAsync ();
				Debug.WriteLine (contenido);

				var parsed = JsonConvert
					.DeserializeObject<GoogleMapsPlaceAutocomplete.Results> (contenido);

				if (GetPlaceAutoCompleteResponse != null) 
				{
					GetPlaceAutoCompleteResponse (this, parsed);
				}
			}
		}
	}
}
