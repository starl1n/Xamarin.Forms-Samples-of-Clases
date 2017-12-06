using System;

using Xamarin.Forms;

namespace XamarinFormsClase02_02
{
	public class PageCarousel : CarouselPage
	{
		public PageCarousel ()
		{
			Title = "Carousel";

			Children.Add (new ContentPage () {
				Padding= 50,
				Title = "Pagina Carousel 01",
				BackgroundColor = Color.Yellow
			});

			Children.Add (new ContentPage ()
			{
				Padding= 50,
				Title = "Pagina Carousel 02",
				BackgroundColor = Color.Green
			});
			Children.Add (new ContentPage ()
			{
				Padding= 50,
				Title = "Pagina Carousel 03",
				BackgroundColor = Color.Purple
			});
		}
	}
}


