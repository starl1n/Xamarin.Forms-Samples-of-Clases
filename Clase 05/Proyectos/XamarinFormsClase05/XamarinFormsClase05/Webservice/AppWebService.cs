
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PLAN
{
	public class AppWebService
	{


		static string HeaderApplication = "application/json";
	
		public string GoogleMapsPath = "https://maps.googleapis.com/maps/api/geocode/json";

		public string GoogleMapDefaultPath = "https://maps.googleapis.com/maps/api/";
		public string GoogleMapsKey = "AIzaSyBNOcv8pK3JobWJhDGyLZwVNUwJleCOCQs";

		public AppWebService ()
		{
		}

		public HttpClient CreateClientGoogleMaps (string Location)
		{
			HttpClient client = null;
			try {
				var formated = string.Format (GoogleMapsPath, Location);

				client = new HttpClient ();
				client.BaseAddress = new Uri (formated);
				client.DefaultRequestHeaders.Accept.Clear ();
				client.DefaultRequestHeaders.Accept.Add (MediaTypeWithQualityHeaderValue.Parse (HeaderApplication));

				var encoder = Encoding.GetEncoding ("ISO-8859-1");
				client.DefaultRequestHeaders.Authorization =
					new AuthenticationHeaderValue (
						"Basic",
						Convert.ToBase64String (encoder.GetBytes (string.Empty)));
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return client;
		}
		public HttpClient CreateClientGoogleMaps ()
		{
			HttpClient client = null;
			try {
				client = new HttpClient ();
				client.BaseAddress = new Uri (GoogleMapDefaultPath);
				client.DefaultRequestHeaders.Accept.Clear ();
				client.DefaultRequestHeaders.Accept.Add (MediaTypeWithQualityHeaderValue.Parse (HeaderApplication));

			
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return client;
		}


		public async Task<T> GetActions<T> (string TableName, string Method, string Parameters, HttpClient Alternativeclient = null) where T : new()
		{
			
			using (var client = CreateClientGoogleMaps()) {
				string jsonData = string.Empty;
				try {
					if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected) {
						string query = (string.IsNullOrEmpty (TableName) ? "" : TableName + "/") + (string.IsNullOrEmpty (Method) ? "" : Method) + "?" + Parameters;
						query = query.Replace ("//", "/");
						Debug.WriteLine ("============ Request: " + client.BaseAddress + query);
						var getDataResponse = await client.GetAsync (query, HttpCompletionOption.ResponseContentRead);
						jsonData = await getDataResponse.Content.ReadAsStringAsync ();

						Debug.WriteLine ("======== Response: " + jsonData);
					}
				} catch (Exception ex) {
					Debug.WriteLine (ex);
				}

				return JsonConvert.DeserializeObject<T> (jsonData, new JsonSerializerSettings {
					NullValueHandling = NullValueHandling.Ignore,
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
					Error = (sender, args) => {
						Debug.WriteLine (args.ErrorContext.Error.Message);
						Debug.WriteLine (args);
						args.ErrorContext.Handled = true;
					}
				});
			}
		}

	}
}
