using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_02
{
	public class App : Application
	{
		public App ()
		{

			var tab = new TabbedPage ();
			tab.Children.Add (new Page01 ());
			tab.Children.Add (new NavigationPage (new Page02 ()) { 
				Title = "Navigation Page",
				Icon = "ic_backup_black_24dp"
			
			});
			tab.Children.Add (new PageCarousel ());
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
