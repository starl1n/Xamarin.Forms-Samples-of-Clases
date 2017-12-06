using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
namespace XamarinFormsClass04_demo
{
	public class LugarViewModel : db
	{
		public LugarViewModel (string Path) : base (Path)
		{
		}


		public List<Lugar> Lugares ()
		{
			var data = new List<Lugar> ();
			try {
				if (Query ().Count > 0) {
					data = Query ();
				} else {
					data = SampleData ();
				}
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return data;
		}

		 List<Lugar> SampleData ()
		{
			var data = new List<Lugar> ();
			data.Add (new Lugar () { Title = "Data Crédito", 
				Address = "Calle Gaspar Polanco 314, Bella Vista, SD, DR" });
			data.Add (new Lugar () { Title = "Caltec", Address = "Av. 27 de Febrero, Bella Vista, SD, DR" });
			data.Add (new Lugar () { Title = "Centro Medico Dominicano", Address = "El Millon, SD, DR" });
			data.Add (new Lugar () { Title = "La Chama", Address = "Av. Nuñez de Caceres, Bella Vista, SD, DR" });
			return data;
		}
	}
}
