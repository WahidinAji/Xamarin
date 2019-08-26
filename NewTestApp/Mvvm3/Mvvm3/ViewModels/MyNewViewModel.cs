using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mvvm3.ViewModels
{
    public class MyNewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MyNewViewModel()
        {
        }

        void OnPropertyChanged ([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        string personname;
        public string PersonName {
            get {
                return personname;
            }
            set {
                personname = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowMessage));
            }
        }

        string worksin;
        public string WorksIn {
            get {
                return worksin;
            }
            set {
                worksin = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowMessage));
            }
        }

        bool myswitch;
        public bool MySwitch {
            get {
                return myswitch;
            }
            set {
                myswitch = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowMessage));
            }
        }

        public string ShowMessage {
            get {
                return $"Mr {PersonName} " + $" Works In " + $" {WorksIn} " + $" {(myswitch ? " is saved to database " : " is not saved to database ")}";
            }
        }
    }
}
