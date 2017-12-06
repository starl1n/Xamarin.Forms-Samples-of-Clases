using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinFormsClase07
{
	public partial class XamarinFormsClase07Page : ContentPage
	{
		public XamarinFormsClase07Page ()
		{
			InitializeComponent ();


			//Fade effect
			btnFadeIn.Clicked += (sender, e) => {
				txtFade.FadeTo (0.7, //Grado de opacidad de 0 a 1
								3000, //Tiempo en milisegundos
								Easing.SpringIn //Efecto para la transición
							   );
			};

			btnFadeOut.Clicked += (sender, e) => {
				txtFade.FadeTo (1, //Grado de opacidad de 0 a 1
								3000, //Tiempo en milisegundos
								Easing.BounceOut //Efecto para la transición
							   );
			};

			//Layout To Effect
			btnLayoutTo.Clicked += (sender, e) => {
				txtLayout.LayoutTo (new Rectangle (txtLayout.X, txtLayout.Y, 
				                                   txtLayout.Width + 50, txtLayout.Height + 50),
								   5000,
								   Easing.SinInOut);
				                   
			};

			//Rotate to effect
			btnRotateTo.Clicked +=  async (sender, e) => {
				await txtRotate.RotateTo (txtRotate.Rotation + 45, //Grados de rotacion
				                          300, 
				                          Easing.SpringIn);
			//	txtRotate.Rotation = 0;
			};

			btnRotateToRel.Clicked +=  async (sender, e) => {
				await txtRotate.RelRotateTo (45, //Grados de rotacion
										  300);
			};

			//Animacion combinada
			btnAnimacionCombinada.Clicked += async (object sender, System.EventArgs e) => {
				await txtRotate.RelRotateTo (45, //Grados de rotacion
										  300);
				await txtRotate.TranslateTo (txtRotate.X +20, //nueva posicion horizontal
				                             txtRotate.Y + 15, //Nueva posicion vertical
										  300);

				await txtRotate.FadeTo (0.2, //Grado de opacidad de 0 a 1
								1000, //Tiempo en milisegundos
								Easing.BounceOut //Efecto para la transición
							   );
			};

			//Animacion compuesta
			btnAnimacionCompuesta.Clicked +=  (object sender, System.EventArgs e) => {
				txtRotate.Opacity = 1;
				 txtRotate.RelRotateTo (45, //Grados de rotacion
										  300);
				txtRotate.TranslateTo (txtRotate.X +500, //nueva posicion horizontal
							 txtRotate.Y + 500, //Nueva posicion vertical
										  30000);

			};


			//Cancelar animacion
			btnCancelAnimation.Clicked += (sender, e) => {
				ViewExtensions.CancelAnimations (txtRotate);
			};


			//Animacion personalizada
			btnPersonalizadas.Clicked += (sender, e) => {
				ViewExtensions_Custom.ColorTo (btnPersonalizadas,
											  btnPersonalizadas.BackgroundColor,
											  Color.Brown, (color) => {
												  btnPersonalizadas.BackgroundColor = color;
											  }, 1000);
			};




			//Gestos
			//Pinch
			var zoom = new PinchGestureRecognizer ();
			zoom.PinchUpdated += (sender, e) => {
				Debug.WriteLine ("El usuario está haciendo zoom");
			};
			img.GestureRecognizers.Add (zoom);

			//pan
			var drag = new PanGestureRecognizer ();
			drag.PanUpdated += (sender, e) => {
				Debug.WriteLine ("El usuario está arrastrando : x= " + e.TotalX + " y: " +e.TotalY);
				img.TranslateTo (e.TotalX, e.TotalY, 50);
			};
			img.GestureRecognizers.Add (drag);

		}
	}


	public   static  class ViewExtensions_Custom
	{
		public static Task<bool> ColorTo (this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing easing = null)
		{
			Func<double, Color> transform = (t) =>
			  Color.FromRgba (fromColor.R + t * (toColor.R - fromColor.R),
							 fromColor.G + t * (toColor.G - fromColor.G),
							 fromColor.B + t * (toColor.B - fromColor.B),
							 fromColor.A + t * (toColor.A - fromColor.A));
			return ColorAnimation (self, "ColorTo", transform, callback, length, easing);
		}

		public static void CancelAnimation (this VisualElement self)
		{
			self.AbortAnimation ("ColorTo");
		}

		static Task<bool> ColorAnimation (VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing)
		{
			easing = easing ?? Easing.Linear;
			var taskCompletionSource = new TaskCompletionSource<bool> ();

			element.Animate<Color> (name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult (c));
			return taskCompletionSource.Task;
		}
	}
}
