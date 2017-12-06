using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
namespace XamarinFormsClass04_demo
{
	public class db
	{
		SQLiteConnection connection;
		public db (string PathToDB)
		{
			connection = new SQLiteConnection (PathToDB);
			connection.CreateTable<Lugar> ();
		}

		public List<Lugar> Query (string search = "")
		{
			var data = connection.Table<Lugar> ();
			if (!string.IsNullOrWhiteSpace (search)) {
				data = data.Where (x => x.Title.Contains (search));
			}
			return data.ToList ();
		}

		public void Save (Lugar record)
		{
			if (record.ID == 0) {
				connection.Insert (record);
			} else {
				connection.InsertOrReplace (record);
			}
		}
	}
}
