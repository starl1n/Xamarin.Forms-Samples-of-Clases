using System;
using SQLite;
namespace XamarinFormsClass04_demo
{
	public class Lugar
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Address { get; set; }
	}
}
