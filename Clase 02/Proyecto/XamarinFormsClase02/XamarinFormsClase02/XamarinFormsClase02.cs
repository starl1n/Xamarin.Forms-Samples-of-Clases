using System;

using Xamarin.Forms;

namespace XamarinFormsClase02
{
	public class App : Application
	{
		public App ()
		{
			

			MainPage = new NavigationPage (new Pagina01());
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
//d@t@c001