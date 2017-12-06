using Xamarin.Forms;

namespace XamarinFormsClase08_Demo
{
	public partial class XamarinFormsClase08_DemoPage : ContentPage
	{
		public XamarinFormsClase08_DemoPage ()
		{
			InitializeComponent ();


			VerificarPosicion.Clicked += VerificarPosicion_Clicked;

			Hablar.Clicked += Hablar_Clicked;

		}

		async void VerificarPosicion_Clicked (object sender, System.EventArgs e)
		{
			var PosicionActual = DependencyService.Get<iOrientacion> ()
			                                      .ObtenerOrientacion();

			if (PosicionActual == Direccion.Vertical) {
				await DisplayAlert ("Posicion", "Posicion Vertical", "Ok");
			} else
			if (PosicionActual == Direccion.Horizontal) {
				await DisplayAlert ("Posicion", "Posicion Horizontal", "Ok");
			} else {
				await DisplayAlert ("Posicion", "No definido", "Ok");
			}
		}

		void Hablar_Clicked (object sender, System.EventArgs e)
		{
			DependencyService.Get<iTextoASonido> ().Speak (texto.Text);
		}
	}
}
