using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Security;
using System.ComponentModel;

namespace XamarinFormsClase11
{
	public static class NamedColor
	{
		public static List<Elementos> All = new List<Elementos> {
			new Elementos{
				Color = "Purple",
				Nombre = "Morado"
			},
			new Elementos{
				Color = "Red",
				Nombre = "Rojo"
			},
			new Elementos{
				Color = "Green",
				Nombre = "Verde"
			}

		};
	}
	public partial class Listado : ContentPage
	{
		public Listado ()
		{
			InitializeComponent ();
		}
	}

	public class Elementos  { 
		public string Color { get; set; }
		public string Nombre { get; set; }

		public event EventHandler OnClick;



	}
}
