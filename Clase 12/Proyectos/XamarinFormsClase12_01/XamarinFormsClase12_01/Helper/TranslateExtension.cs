using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsClase12_01
{
	// You exclude the 'Extension' suffix when using in Xaml markup
	[ContentProperty ("Text")]
	public class TranslateExt : IMarkupExtension
	{
		readonly CultureInfo ci;
		const string ResourceId = "XamarinFormsClase12_01.RESX.Clase12Resource";

public TranslateExt ()
		{
				
			if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android) {
				ci = DependencyService.Get<iLocalize> ().GetCurrentCultureInfo ();
			}
		}

		public string Text { get; set; }

		public object ProvideValue (IServiceProvider serviceProvider)
		{
			if (Text == null)
				return "";

			ResourceManager resmgr = new ResourceManager (ResourceId
								, typeof (TranslateExt).GetTypeInfo ().Assembly);

			var translation = resmgr.GetString (Text, ci);

			if (translation == null) {
				#if DEBUG
	                throw new ArgumentException (
	                    String.Format ("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name),
	                    "Text");
				#else
				translation = Text; // HACK: returns the key, which GETS DISPLAYED TO THE USER
				#endif
			}
			return translation;
		} 
	}
}
