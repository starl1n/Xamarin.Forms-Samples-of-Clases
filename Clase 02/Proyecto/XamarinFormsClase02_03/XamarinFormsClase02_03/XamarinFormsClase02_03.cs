using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_03
{
	public class App : Application
	{
		public App ()
		{
			var masterdetail = new MasterDetailPage ();
			masterdetail.Master = new Master ();
			masterdetail.Detail = new NavigationPage(new Details ());
			MainPage = masterdetail;
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
