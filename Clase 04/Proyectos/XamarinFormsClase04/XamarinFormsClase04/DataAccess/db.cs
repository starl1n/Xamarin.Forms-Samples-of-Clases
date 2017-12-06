using System;
using SQLite;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;

namespace XamarinFormsClase04
{
	public class db
	{
		public SQLiteConnection connection;
		public db (string Path)
		{
			connection = new SQLiteConnection (Path);
			connection.CreateTable<Place>();     
		}

		public List<Place> Query (string search ="")
		{
			var query  = connection.Table<Place> ();
			if (!string.IsNullOrEmpty (search)) {
				query.Where (x => x.Name.Contains (search));
			}

			return query.ToList ();
		}

		public void Save (Place data)
		{
			connection.InsertOrReplace (data);
		}
	}
}
