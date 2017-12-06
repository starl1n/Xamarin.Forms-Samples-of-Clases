using Xamarin.Forms;
using XamarinFormsClase12_01.RESX;

namespace XamarinFormsClase12_01
{
	public partial class XamarinFormsClase12_01Page : ContentPage
	{
		public XamarinFormsClase12_01Page ()
		{
			InitializeComponent ();

			var ci = DependencyService.Get<iLocalize> ().GetCurrentCultureInfo ();
			RESX.Clase12Resource.Culture = ci; // set the RESX for resource localization
		    	DependencyService.Get<iLocalize>().SetLocale (ci); // s
			btnSave.Text = Clase12Resource.btnSave;
		}
	}
}
