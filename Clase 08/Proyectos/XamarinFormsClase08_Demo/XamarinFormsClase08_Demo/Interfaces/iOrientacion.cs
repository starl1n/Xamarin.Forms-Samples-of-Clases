using System;
namespace XamarinFormsClase08_Demo
{
	public enum Direccion{
		Indefinido,
		Vertical,
		Horizontal
	}

	public interface iOrientacion
	{
		Direccion ObtenerOrientacion ();
	}
}
