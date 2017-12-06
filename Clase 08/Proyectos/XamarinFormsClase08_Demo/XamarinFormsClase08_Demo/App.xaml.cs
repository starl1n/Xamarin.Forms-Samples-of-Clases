using Xamarin.Forms;

namespace XamarinFormsClase08_Demo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			MainPage = new XamarinFormsClase08_DemoPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
