using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ButtonCB.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; private set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LogUser());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string user;
        public string User {
            get => user;
            set {
                if (user != value)
                {
                    user = value;
                }
                OnPropertyChanged();
            }
        }

        private string pass;
        public string Pass {
            get => pass;
            set {
                if (pass != value)
                {
                    pass = value;
                }
                OnPropertyChanged();
            }
        }

        async Task LogUser()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.DashBoardPage());
        }
    }
}
