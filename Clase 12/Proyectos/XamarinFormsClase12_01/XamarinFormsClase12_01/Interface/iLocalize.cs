using System;
using System.Globalization;
namespace XamarinFormsClase12_01
{
	public interface iLocalize
	{
		CultureInfo GetCurrentCultureInfo ();
		void SetLocale (CultureInfo culture);
	}
}
