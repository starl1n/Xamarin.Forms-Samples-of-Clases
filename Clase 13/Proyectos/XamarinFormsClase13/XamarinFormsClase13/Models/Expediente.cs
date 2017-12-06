using System;
using System.IO;
using Xamarin.Forms;

namespace XamarinFormsClase13
{
	public class Expediente
	{
		
			public int Id { get; set; }
			public int Id_Expediente { get; set; }
			public int Id_Producto { get; set; }
			public int Id_Relacion_Tipo { get; set; }
			public string Exp_C_Guid { get; set; }
			public string Ent_D_Documento { get; set; }
			public string Nombre_Completo { get; set; }
			public string Ent_D_Nombres { get; set; }
			public string Ent_D_Apellidos { get; set; }
			public string Ent_B_Imagen { get; set; }
			public DateTime Exp_F_Expediente { get; set; }
			public string Descripcion_Relacion_Tipo { get; set; }
			public int Id_Estatus { get; set; }
			public int Id_Etapa_Flujo { get; set; }
			public string Def_C_Guid { get; set; }
			public string Ent_B_Imagen1 { get; set; }
			

			public ImageSource image { get; set; }
			public string Descripcion_Producto { get; set; }
			public string Descripcion_Estatus { get; set; }
			public string Descripcion_Etapa_Flujo { get; set; }
			public int? Id_Analista { get; set; }
			public int? Id_Comite { get; set; }
			public int Id_Gerente { get; set; }

	}
}