using Xamarin.Forms;

namespace XamarinFormsWorkflow
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			var masterDetail = new MasterDetailPage ();
			masterDetail.Master = new NavigationPage (new SideBar ()) { 
									Title="Menu"
								};
			masterDetail.Detail = new NavigationPage (new Login ());

			MainPage = masterDetail;
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
