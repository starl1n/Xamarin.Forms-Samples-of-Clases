using System;
using System.Diagnostics;
using Xamarin.Forms;
using XamarinFormsClase08_Demo.iOS;
using UIKit;
[assembly: Dependency(typeof(Orientacion))]
namespace XamarinFormsClase08_Demo.iOS
{
	public class Orientacion : iOrientacion
	{
		

		public Direccion ObtenerOrientacion ()
		{
			var resultado = Direccion.Indefinido;
			try {
				bool esVertical;
				var OrientacionActual = UIApplication
					.SharedApplication
					.StatusBarOrientation;
				esVertical = OrientacionActual.IsPortrait ();

				resultado = esVertical? Direccion.Vertical : Direccion.Horizontal;

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return resultado;
		}
	}
}
