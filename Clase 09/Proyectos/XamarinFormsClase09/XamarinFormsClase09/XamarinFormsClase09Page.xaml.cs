using Xamarin.Forms;

namespace XamarinFormsClase09
{
	public partial class XamarinFormsClase09Page : ContentPage
	{
		public XamarinFormsClase09Page ()
		{
			InitializeComponent ();
			//var navegador = new WebView ();
			//Mostrar un website
			//webView.Source = "http://valegoconsulting.com";//Esto en iOS generará un error por que es una dirección es insegura.
			//webView.Source = "https://bing.com";

			//HTML string 
			//var contenidoHTML = new HtmlWebViewSource ();
			//contenidoHTML.Html = @"<h2>Data Crédito</h2>";
			//webView.Source = contenidoHTML;


			//HTML incluido en el proyecto
			var contenidoHTML = new HtmlWebViewSource ();
			contenidoHTML.Html =  DependencyService.Get<iHTMLRutas>().Ruta("pagina.html");
			webView.Source = contenidoHTML;
			//Content = navegador;

		}
	}
}
