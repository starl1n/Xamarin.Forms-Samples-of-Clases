using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsWorkflow
{
	public partial class SideBar : ContentPage
	{
		public SideBar ()
		{
			InitializeComponent ();

			var textcell = new TextCell ();
			textcell.Text = "Dashboard";
			Opciones.ItemsSource = new string [] {"Dashboard", "Originación",
			"Documentación",
			"Análisis de Crédito",
			"Comité de Crédito",
			"Formalización",
				"Cierre"
			};
		}
	}
}
