using System;
using SQLite;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;
namespace XamarinFormsWorkflow
{

	public class db
	{
		public SQLiteConnection connection;
		public db (string Path)
		{
			connection = new SQLiteConnection (Path);
			connection.CreateTable<Account> ();
		}

		public IEnumerable<T> GetItems<T> ()
			where T : class, iBaseModel, new()
		{

			return connection.Table<T> ();
		}

		public void SaveItem<T> (T item) where T : class, iBaseModel, new()
		{

			if (item != null) {

				var recordExist = connection.Table<T> ()
											.FirstOrDefault
											(x => x.GUID == item.GUID);
				if (recordExist != null) {
					connection.Update (item);
				} else {
					connection.Insert (item);
				}
			}
		}
	}
}