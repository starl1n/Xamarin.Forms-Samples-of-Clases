using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsClass04_demo.Droid;

[assembly: Dependency (typeof (FileHelper2))]
namespace XamarinFormsClass04_demo.Droid
{

	public class FileHelper2 : IFileHelper
	{
		public string DatabasePath (string nombreArchivo)
		{
			string path = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			return Path.Combine (path, nombreArchivo);

		}
	}


}
