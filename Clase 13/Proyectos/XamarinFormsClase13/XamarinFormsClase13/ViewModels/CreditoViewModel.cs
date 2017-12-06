using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace XamarinFormsClase13
{
	public class CreditoViewModel
	{
		public AppWebservice service;

		public CreditoViewModel ()
		{
			service = new AppWebservice ();
		}

		#region Consumir el servicio
		public event EventHandler<string> LoginResponse;
		public async Task Login (string username, string password)
		{
			string query = "Username=" + username + "&Password=" + password;
			var response = await service.GetActions ("Originacion", "", query);


			if (LoginResponse != null) {
				LoginResponse (this, response);
			}
		}
public event EventHandler<List<Expediente>> ExpedientesResponse;
public async Task Expedientes (
							string Token = "",
							int vIdEtapaFlujo = 5, 
		                       int vIdSucursal = 13,
		                       int vIdUsuario = 5

		                       )
{
	string query = "vIdEtapaFlujo=" + vIdEtapaFlujo + 
				"&vIdSucursal=" + vIdSucursal +
				"&vIdUsuario=" + vIdUsuario +
				"&Token=" + Token ;
	var response = await service.GetActions ("Originacion", "", query);

			var parsedResponse = JsonConvert.DeserializeObject<List<Expediente>> (response);
	if (ExpedientesResponse != null) {
		ExpedientesResponse (this, parsedResponse);
	}
}

		#endregion
	}
}
