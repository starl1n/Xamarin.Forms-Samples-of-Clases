using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace XamarinFormsWorkflow
{
	public class AccountViewModel : BaseViewModel
	{
		public AccountViewModel (string dbPath) : base (dbPath)
		{
		}

		public bool CanLogIn (string Username, string Password)
		{
			try {
				var cuenta = DataEjemplo()//GetItems<Account> ()
					.Count (x => x.Username == Username &&
							x.Password == Password);
				if(cuenta > 0)
					return true;
				
			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
			return false;
		}

		public List<Account> DataEjemplo ()
		{
			var data = new List<Account> ();
			data.Add (new Account () {
				Username = "demo",
				Password = "123456"
			});

			data.Add (new Account ()
			{
				Username = "prueba",
				Password = "123456"
			});
			data.Add (new Account ()
			{
				Username = "guillermo",
				Password = "123456"
			});
			return data;
		}
	}
}
