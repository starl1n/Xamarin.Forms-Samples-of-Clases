using System;

using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinFormsClase04
{
	public class DetalleLugar : ContentPage
	{
		Place Data;
		PlaceViewModel viewModel;
		Entry Name = new Entry(), 
		Latitude= new Entry(), 
		Longitude= new Entry();
		Button btnSave = new Button () { TextColor = Color.Blue, Text = "Guardar" },

		btnCancel = new Button () { Text = "Cancelar"};


		Editor FormatedAddress = new Editor ();
		public DetalleLugar (Place data)
		{
			var databasePath = DependencyService.Get<IFileHelper> ().GetLocalFilePath ("database.db3");
            viewModel = new PlaceViewModel (databasePath);
			
			Data = data;
			BindData ();
			//Interfaz
			var interfaz = new StackLayout () {
				Padding = 20
			};
			interfaz.Children.Add (
								  new StackLayout {
										Children = { 
											new Label{ Text= "Nombre"},
											Name
										},
									  Orientation = StackOrientation.Horizontal,

								  });
			interfaz.Children.Add (
								  new StackLayout {
										Children = { 
						new Label{ Text= "Dirección", HorizontalOptions = LayoutOptions.StartAndExpand},
											FormatedAddress
										},
									  Orientation = StackOrientation.Horizontal,

								  });
			interfaz.Children.Add (
								  new StackLayout {
										Children = { 
											new Label{ Text= "Latitude"},
											Latitude
										},
									  Orientation = StackOrientation.Horizontal,

								  });
			interfaz.Children.Add (
								  new StackLayout {
										Children = { 
											new Label{ Text= "Longitude"},
											Longitude
										},
									  Orientation = StackOrientation.Horizontal,

								  });

			interfaz.Children.Add (
								  new StackLayout {
										Children = { 
											btnCancel,
											btnSave
										},
										HorizontalOptions = LayoutOptions.Center,
									  Orientation = StackOrientation.Horizontal,

								  });
			
			Content = interfaz;


			btnCancel.Clicked+= BtnCancel_Clicked;
			btnSave.Clicked += BtnSave_Clicked;

		}


		void BindData ()
		{
			try {
				if (Data != null) {
					Name.Text = Data.Name ?? "";
					FormatedAddress.Text = Data.FormatedAddress ?? "";
					Latitude.Text = Data.Latitude.ToString() ?? "";
					Longitude.Text = Data.Longitude.ToString() ?? "";


					Title = Data.Name;
				}
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
		}

		async void BtnCancel_Clicked (object sender, EventArgs e)
		{
			await this.Navigation.PopAsync ();
		}


		async void BtnSave_Clicked (object sender, EventArgs e)
		{
			try {

				Data.Name = Name.Text;
				Data.FormatedAddress = FormatedAddress.Text;
				Data.Latitude = double.Parse(Latitude.Text);
				Data.Longitude = double.Parse (Longitude.Text);

				var validation = viewModel.Validate (Data);
				if (validation.ContainsKey (true)) {
					viewModel.Save (Data);
					await DisplayAlert ("Exito", validation [true], "Ok");
					await this.Navigation.PopAsync ();
				} else {

					await DisplayAlert ("Error", validation [false], "Ok");
				}

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
		}
	}
}

