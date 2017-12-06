using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ModernHttpClient;

namespace XamarinFormsClase13
{
public class AppWebservice
{
	//Ejemplo URL
	//https://maps.googleapis.com/maps/api/place/textsearch/json?query=hilton&types=lodging&key=AIzaSyC_SwjpcVp2fMr-Elbzakzo_FU_O_8koHc
public string WebServiceBasePath = "http://wcf.caltec.do/WebservicesWCF/api/";
	
	public AppWebservice ()
	{
	}

	public HttpClient CrearClient ()
	{
		HttpClient client = null;
		try {
				client = new HttpClient (new NativeMessageHandler());
			client.BaseAddress = new Uri (WebServiceBasePath);
			client.DefaultRequestHeaders.Accept
				  .Add ((MediaTypeWithQualityHeaderValue)MediaTypeHeaderValue
						.Parse ("application/json"));
		} catch (Exception ex) {
			Debug.WriteLine (ex);
		}

		return client;
	}
public async Task<T> GetActions<T> (string TableName, string Method, string Parameters, HttpClient Alternativeclient = null) where T : new()
{

	using (var client = CrearClient ()) {
		string jsonData = string.Empty;
		try {
		///	if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected) {
				string query = (string.IsNullOrEmpty (TableName) ? "" : TableName + "/") + (string.IsNullOrEmpty (Method) ? "" : Method) + "?" + Parameters;
				query = query.Replace ("//", "/");
				Debug.WriteLine ("============ Request: " + client.BaseAddress + query);
				var getDataResponse = await client.GetAsync (query, HttpCompletionOption.ResponseContentRead);
				jsonData = await getDataResponse.Content.ReadAsStringAsync ();

				Debug.WriteLine ("======== Response: " + jsonData);
			//}
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



		public async Task<string> GetActions (string TableName, string Method, string Parameters, HttpClient Alternativeclient = null)
		{

			using (var client = CrearClient ()) {
				string jsonData = string.Empty;
				try {
					///	if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected) {
					string query = (string.IsNullOrEmpty (TableName) ? "" : TableName + "/") + (string.IsNullOrEmpty (Method) ? "" : Method) + "?" + Parameters;
					query = query.Replace ("//", "/");
					Debug.WriteLine ("============ Request: " + client.BaseAddress + query);
					var getDataResponse = await client.GetAsync (query, HttpCompletionOption.ResponseContentRead);
					jsonData = await getDataResponse.Content.ReadAsStringAsync ();

					Debug.WriteLine ("======== Response: " + jsonData);
					//}
				} catch (Exception ex) {
					Debug.WriteLine (ex);
				}

				return JsonConvert.DeserializeObject<string> (jsonData, new JsonSerializerSettings {
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
