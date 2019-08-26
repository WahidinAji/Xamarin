using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVMBasics2.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public TestViewModel()
        {
            this.DateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }

        DateTime dateTime;
        public DateTime DateTime {
            get {
                return dateTime;
            }
            set {
                if (dateTime!= value)
                {
                    dateTime = value;
                    if (PropertyChanged!= null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
