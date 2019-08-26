using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TwoWay.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        string forename, surename;
        public string Forename {
            get {
                return forename;
            }
            set {
                if (forename != value)
                {
                    forename = value;
                    OnPropertyChanged("Forename");
                }
            }
        }
        public string Surename {
            get {
                return surename;
            }
            set {
                if (surename != value)
                {
                    surename = value;
                    OnPropertyChanged("Surename");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
