using System;

using Xamarin.Forms;

namespace XamarinFormsClase03
{
	public class App : Application
	{
		public App ()
		{


			MainPage = new MasterDetailPage () {
				Title = "Master Detail",
				Master = new Master (),
				Detail = new NavigationPage (new Details (null)) {
					Title = "Details"
				}
			
			};
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
