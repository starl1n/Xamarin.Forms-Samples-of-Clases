using System;
using System.IO;
using System.Threading.Tasks;
namespace XamarinFormClase08
{
	public interface IPickerInterface
	{
		Task<Stream> GetImageStream ();
	}
}
