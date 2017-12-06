using System;

using Xamarin.Forms;

namespace XamarinFormsClass04_demo
{
	public class App : Application
	{
		public App ()
		{
			var tabbed = new TabbedPage ();
			tabbed.Children.Add (
								new NavigationPage (new ListadoDeLugares ()) {
									Title = "Lugares",

								});

			tabbed.Children.Add (
								new NavigationPage (new DetalleLugar ( null)) {
									Title = "Crear nuevo",

								});
			
			MainPage = tabbed;
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
