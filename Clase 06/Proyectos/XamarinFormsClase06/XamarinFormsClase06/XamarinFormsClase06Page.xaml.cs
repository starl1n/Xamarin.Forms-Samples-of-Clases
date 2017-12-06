using Xamarin.Forms;

namespace XamarinFormsClase06
{
	public partial class XamarinFormsClase06Page : ContentPage
	{
		public XamarinFormsClase06Page ()
		{
			InitializeComponent ();

			CampoDeTexto.Text = "Texto desde el codigo";
			CampoDeTexto.IsPassword = true;
		}
	}
}
