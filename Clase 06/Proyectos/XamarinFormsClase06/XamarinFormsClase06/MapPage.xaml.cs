﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinFormsClase06
{
	public partial class MapPage : ContentPage
	{
		public MapPage ()
		{
			InitializeComponent ();

		var map = new Map (
					MapSpan.FromCenterAndRadius (
							new Position (37, -122), Distance.FromMiles (0.3))) {
			IsShowingUser = true,
			HeightRequest = 100,
			WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			Contenedor.Children.Add (map);
		}
	}
}
