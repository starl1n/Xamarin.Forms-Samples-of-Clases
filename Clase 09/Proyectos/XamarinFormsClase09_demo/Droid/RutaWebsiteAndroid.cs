using System;
using Xamarin.Forms;
using XamarinFormsClase09_demo.Droid;
using Javax.Xml.Transform.Stream;
using System.IO;


[assembly: Dependency(typeof(RutaWebsiteAndroid))]
namespace XamarinFormsClase09_demo.Droid
{
	public class RutaWebsiteAndroid : RutaWebsites
	{
		

		public string Ruta (string Archivo)
		{
			var assetManager = Xamarin.Forms.Forms.Context.Assets;
			var html = "";
			using (var reader = new StreamReader (assetManager.Open (Archivo))) 
			{
				html = reader.ReadToEnd ();
			}
			return html;
		}
	}
}
