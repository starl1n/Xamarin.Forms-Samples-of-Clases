using Xamarin.Forms;

namespace XamarinFormsClase09_demo
{
	public partial class XamarinFormsClase09_demoPage : ContentPage
	{
		public XamarinFormsClase09_demoPage ()
		{
			InitializeComponent ();

			//navegador.Source = "http://youtube.com";

			var html = new HtmlWebViewSource ();
			//			html.Html = "<a href=\"http://twitter.com\">Enlace de prueba</a>";

			html.Html = DependencyService.Get<RutaWebsites> ().Ruta ("index.html");

			navegador.Source = html;



			navegador.Navigated+= Navegador_Navigated;
			navegador.Navigating+= Navegador_Navigating;
			btnBack.Clicked += BtnBack_Clicked;
			btnForward.Clicked += BtnForward_Clicked;
		}

		void Navegador_Navigated (object sender, 
		                          WebNavigatedEventArgs e)
		{
			
		}

		void Navegador_Navigating (object sender, WebNavigatingEventArgs e)
		{
				
		}

		void BtnBack_Clicked (object sender, System.EventArgs e)
		{
			navegador.GoBack ();
		}

		void BtnForward_Clicked (object sender, System.EventArgs e)
		{
			navegador.Source = "file:////developer.xamarin.com/guides/cross-platform/getting_started/offline.pdf";
	//		navegador.GoForward ();
		}
	}
}
