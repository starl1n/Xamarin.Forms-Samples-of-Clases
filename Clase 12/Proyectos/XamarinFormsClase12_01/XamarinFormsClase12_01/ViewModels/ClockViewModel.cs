using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinFormsClase12_01
{
	public class ClockViewModel : INotifyPropertyChanged
	{
		public ClockViewModel ()
		{
			this.DateTime = DateTime.Now;

			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    this.DateTime = DateTime.Now;
                    return true;

			   });

			//Para probar los comandos
			//Device.StartTimer(TimeSpan.FromMinutes(1), () =>
   //             {
   //                 this.DateTime = DateTime.Now;
   //                 return true;

			//   });


			//Metodo implementado de Command
			AlertTime = new Command ( (obj) => {
				this.DateTime = DateTime.Now;
			});
		}

		DateTime datetime;
		public DateTime DateTime 
		{
			get { return datetime; }
			set {
				datetime = value;
				if (PropertyChanged != null) {
					PropertyChanged (this, new PropertyChangedEventArgs ("DateTime"));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;



		public ICommand AlertTime { get; set; }
	}
}
