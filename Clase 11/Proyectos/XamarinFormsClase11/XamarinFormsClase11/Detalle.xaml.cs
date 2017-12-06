using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsClase11
{
	public partial class Detalle : ContentPage
	{
		public Elementos data = new Elementos {
			Color = "Red",
			Nombre = "Morado"
		};
		public Detalle ()
		{
			
			InitializeComponent ();

			BindingContext = data;
		}

		void Handle_Clicked (object sender, System.EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}
