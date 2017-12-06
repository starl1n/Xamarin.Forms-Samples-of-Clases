using System;
using SQLite;

namespace XamarinFormsWorkflow
{
	public class BaseModel : iBaseModel
	{
		public DateTime? Creation {
			get; set;
		}

		public DateTime? Delete {
			get;set;
		}

		[PrimaryKey]
		public string GUID {
			get;

			set;
		}

		public DateTime? Update {
			get;set;
		}
	}
}
