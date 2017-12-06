using System;
using Xamarin.Forms;
using XamarinFormsClase09.Droid;
using Android.Content.Res;
using System.IO;

[assembly: Dependency(typeof(Rutas))]
namespace XamarinFormsClase09.Droid
{
	public class Rutas :iHTMLRutas
	{
		public Rutas ()
		{
		}

		public string Ruta (string archivo)
		{
			var assetManager = Xamarin.Forms.Forms.Context.Assets;
			var html = "";
			using (var streamReader = new StreamReader (assetManager.Open (archivo))){
				html = streamReader.ReadToEnd ();
			}

			return html;
		}
	}
}
