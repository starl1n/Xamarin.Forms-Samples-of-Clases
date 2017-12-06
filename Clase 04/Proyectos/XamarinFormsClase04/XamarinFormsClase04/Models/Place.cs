using System;
using SQLite;
namespace XamarinFormsClase04
{
	public class Place
	{
		[PrimaryKey,AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string IDOnGoogle { get; set; }
		public string FormatedAddress { get; set; }
	}
}
