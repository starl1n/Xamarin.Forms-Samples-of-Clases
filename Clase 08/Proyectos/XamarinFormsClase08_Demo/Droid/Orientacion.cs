using System;
using System.Diagnostics;
using Xamarin.Forms;
using XamarinFormsClase08_Demo.Droid;
using Android.Views;
using Android.Content;
using Java.Interop;

[assembly: Dependency(typeof(Orientacion))]
namespace XamarinFormsClase08_Demo.Droid
{
	public class Orientacion : iOrientacion
	{
		

		public Direccion ObtenerOrientacion ()
		{
			var resultado = Direccion.Indefinido;
			try {
				IWindowManager windowM = Android.App.Application
												.Context.GetSystemService
				                                (Context.WindowService)
												.JavaCast<IWindowManager> ();

				var rotacion = windowM.DefaultDisplay.Rotation;
				var esVertical = 	rotacion == SurfaceOrientation.Rotation0 ||
							   		rotacion == SurfaceOrientation.Rotation180;
				resultado = esVertical ? Direccion.Vertical : Direccion.Horizontal;

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}


			return resultado;
		}
	}
}
