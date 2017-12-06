using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_02
{
	public class Page01 : ContentPage
	{
		public Page01 ()
		{
			switch (Device.RuntimePlatform) {
				case Device.iOS:
				Padding = new Thickness(20,50,0,0);
				//Padding  = 50;
				break;
				default:
				Padding = 0;
				break;
			}
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
			Title = "Page 01";
			Icon = "ic_account_circle_black_24dp";
		}
	}
}

