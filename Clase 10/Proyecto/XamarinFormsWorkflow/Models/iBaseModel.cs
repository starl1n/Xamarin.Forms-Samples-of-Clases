using System;
namespace XamarinFormsWorkflow
{
	public interface iBaseModel
	{

		string GUID { get; set; }
		DateTime? Creation { get; set; }
		DateTime? Update { get; set; }
		DateTime? Delete { get; set; }
	}
}
