using OneWay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneWay.ViewModels
{
    public class LoginViewModel
    {
        private LoginModel loginModel;
        public LoginModel LoginModel {
            get {
                return loginModel;
            }
            set {
                loginModel = value;
            }
        }

        public LoginViewModel()
        {
            LoginModel = new LoginModel()
            {
                UserName = "Wahidin",
                Password = "123456"
            };
        }
    }
}
