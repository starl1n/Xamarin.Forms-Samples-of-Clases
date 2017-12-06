using System;
using Xamarin.Forms.Platform.iOS;
using System.Security.Policy;
using XamarinFormsClase09;
using XamarinFormsClase09.iOS;
using Xamarin.Forms;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(EntryPersonalizado), typeof(EntryPersonalizadoRenderer))]

namespace XamarinFormsClase09.iOS
{
	public class EntryPersonalizadoRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				//Actualizar el estilo o funcionalidad aquí
				Control.BackgroundColor = UIColor.Black;
				Control.TextColor = UIColor.White;

			}
		}
	}
}
