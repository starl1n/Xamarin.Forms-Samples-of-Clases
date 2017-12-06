

using System.Threading.Tasks;

namespace XamarinFormsClase05_Demo
{
	public class GoogleViewModel 
	{
		public AppWebservice servicioweb = new AppWebservice ();

		public async Task BuscarLugar (string lugar)
		{

			await servicioweb.Get ("place", "autocomplete/json", lugar);
		}
	}
}

