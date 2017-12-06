using System;
using Xamarin.Forms;
using XamarinFormsWorkflow.Droid;

[assembly : Dependency(typeof(RutaDB))]
namespace XamarinFormsWorkflow.Droid
{
	public class RutaDB : iRutaDB
	{
		public string Ruta (string Archivo)
		{
			string direccion = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			return direccion + Archivo;
		}
	}
}
