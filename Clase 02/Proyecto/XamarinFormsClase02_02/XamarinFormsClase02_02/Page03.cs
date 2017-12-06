using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_02
{
	public class Page03 : ContentPage
	{
		public Page03 ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage Page 3" }
				}
			};
			Title = "Page 03";
		}
	}
}

