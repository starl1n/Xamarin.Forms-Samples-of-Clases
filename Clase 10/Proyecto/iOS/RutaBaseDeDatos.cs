using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsWorkflow.iOS;

[assembly: Dependency(typeof(RutaBaseDeDatos))]
namespace XamarinFormsWorkflow.iOS
{
	public class RutaBaseDeDatos : iRutaDB
	{
		

		public string Ruta (string Archivo)
		{
			string docFolder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine (docFolder, "..", "Library", "Databases");

			if (!Directory.Exists (libFolder)) {
				Directory.CreateDirectory (libFolder);
			}

			return Path.Combine (libFolder, Archivo);
		}
	}
}
