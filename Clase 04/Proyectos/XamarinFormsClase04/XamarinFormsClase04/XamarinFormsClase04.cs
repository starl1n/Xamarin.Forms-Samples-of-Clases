using System;

using Xamarin.Forms;

namespace XamarinFormsClase04
{
	public class App : Application
	{
		public App ()
		{
			var tab = new TabbedPage ();
			tab.Children.Add (
				new NavigationPage(root: new Lugares()) { 
					Title = "Listado",
						
				});
			MainPage = tab;
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
