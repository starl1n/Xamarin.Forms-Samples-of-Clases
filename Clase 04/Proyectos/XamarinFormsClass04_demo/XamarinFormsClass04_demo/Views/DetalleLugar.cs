using System;
using Xamarin.Forms;
namespace XamarinFormsClass04_demo
{
	public class DetalleLugar : ContentPage
	{
		Lugar Data;
		LugarViewModel viewModel;
		StackLayout interfaz;
		Entry nombre = new Entry { Placeholder = "Nombre del lugar" },
		direccion = new Entry { Placeholder = "Dirección fisica" };

		Button cancelar = new Button () { 
		Text = "Cancelar"
		},
		guardar = new Button () {
			BackgroundColor = Color.Green,
			TextColor = Color.White,
			Text = "Guardar"
		};

		public DetalleLugar ( Lugar data)
		{
			string path = DependencyService.Get<IFileHelper> ().DatabasePath ("database.db");
			
			viewModel = new LugarViewModel (path);



			Data = data;
			cancelar.Clicked+= Cancelar_Clicked;
			guardar.Clicked += Guardar_Clicked;

			interfaz = new StackLayout ();
			interfaz.Padding = 20;
			interfaz.Children.Add (new Label { Text = "Nombre" });
			interfaz.Children.Add (nombre);
			interfaz.Children.Add (new Label { Text = "Dirección" });
			interfaz.Children.Add (direccion);

			interfaz.Children.Add (
				new StackLayout { 
					Orientation = StackOrientation.Horizontal,
					HorizontalOptions = LayoutOptions.Center,
					Children = {
						cancelar, guardar
					}
				
				}
			
			);

			Content = new ScrollView {
				Content = interfaz
			};



			//Binding
			if (data != null) {
				Title = data.Title;

				nombre.Text = data.Title;
				direccion.Text = data.Address;
			}
		}

		async void Cancelar_Clicked (object sender, EventArgs e)
		{
			await (Parent as NavigationPage).PopAsync (true);
		}

		async void Guardar_Clicked (object sender, EventArgs e)
		{
			if (Data == null) {
				Data = new Lugar ();
			}
			Data.Address = direccion.Text ?? "";
			Data.Title = nombre.Text ?? "";

			viewModel.Save (Data);
			Data = null;
			await DisplayAlert ("Exito", "Elemento almacenado", "Ok");

            await (Parent as NavigationPage).PopAsync (true);
		}
	}
}
