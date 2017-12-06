
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using XamarinFormsClase09.Droid;
using XamarinFormsClase09;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(EntryPersonalizado), typeof(EntryPersonalizadoRenderer))]
namespace XamarinFormsClase09.Droid
{
	public class EntryPersonalizadoRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				//Actualizar el estilo o funcionalidad aquí
				Control.SetBackgroundColor (Android.Graphics.Color.Black);
				Control.SetTextColor (Android.Graphics.Color.White);

			}
		}
	}
}
