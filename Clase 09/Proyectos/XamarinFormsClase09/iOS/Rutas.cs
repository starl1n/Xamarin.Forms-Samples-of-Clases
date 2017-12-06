using System;
using Xamarin.Forms;
using XamarinFormsClase09.iOS;
using Foundation;
using System.IO;

[assembly: Dependency(typeof(Rutas))]
namespace XamarinFormsClase09.iOS
{
	public class Rutas:iHTMLRutas
	{
		

		public string Ruta (string archivo)
		{
			var texto = File.ReadAllText (archivo);
			return texto;
		}
	}
}
