using Xamarin.Forms;

namespace XamarinFormsWorkflow
{
	public partial class App : Application
	{

		AccountViewModel viewModel;

		public App ()
		{
			var dbPath = DependencyService.Get<iRutaDB> ().Ruta ("database.db");
			viewModel = new AccountViewModel (dbPath );

			InitializeComponent ();

			if (viewModel.CanLogIn ("demo", "123456")) {

				var masterDetail = new MasterDetailPage ();
				masterDetail.Master = new NavigationPage (new SideBar ()) {
					Title = "Menu"
				};
				masterDetail.Detail = new NavigationPage (new Dashboard ());

				MainPage = masterDetail;
			} else {

				MainPage = new Login ();
			}
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
