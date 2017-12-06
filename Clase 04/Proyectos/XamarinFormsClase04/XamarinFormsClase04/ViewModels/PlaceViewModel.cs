using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
namespace XamarinFormsClase04
{
	public class PlaceViewModel : db
	{
		public PlaceViewModel (string path):base(path)
		{
		}

		public List<Place> Get ()
		{
			var data = new List<Place> ();
			try {
				data = Query ();
				if (data.Count == 0) {
					data = SamplePlaces ();
				}
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return data;
		}


		List<Place> SamplePlaces ()
		{
			var data = new List<Place> ();
			try {
				data.Add (new Place {
					Name = "Data Crédito",
					FormatedAddress = "Calle Gaspar Polanco 314, Santo Domingo",
					Latitude = 18.4537937,
					Longitude = -69.9549247
				});
				data.Add (new Place {
					Name = "Centro Médico Dominicano",
					FormatedAddress = "Calle Luis F. Thomen 456, Santo Domingo 10149",
					Latitude = 18.4537937,
					Longitude = -69.9549247
				});

				data.Add (new Place {
					Name = "Colegio Quisqueya",
					FormatedAddress = "Calle Gaspar Polanco, Santo Domingo",
					Latitude = 18.4537937,
					Longitude = -69.9549247
				});

				data.Add (new Place {
					Name = "Farmacia Los Hidalgos",
					FormatedAddress = "Avenida 27 de Febrero #417, Ensanche Quisqueya, casi esq. Núñez de Cáceres, Santo Domingo 10142",
					Latitude = 18.45554,
					Longitude = -69.953011
				});
				data.Add (new Place {
					Name = "Multigrabado",
					FormatedAddress = "Calle Luis F. Thomen 456, Santo Domingo 10149",
					Latitude = 18.4537937,
					Longitude = -69.9549247
				});

				data.Add (new Place {
					Name = "Unirefri",
					FormatedAddress = "Calle Gaspar Polanco, Santo Domingo",
					Latitude = 18.4537937,
					Longitude = -69.9549247
				});


			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return data;
		}


		public Dictionary<bool, string> Validate (Place data)
		{
			var response = new Dictionary<bool, string> ();

			try {


				if (string.IsNullOrWhiteSpace (data.Name)) {
					response.Add (false, "El nombre es requerido");
					return (response);
				}
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}


			response.Add (true, "Valido");
			return (response);
		}
	}
}
