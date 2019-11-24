using SyncfusionXamarinApp2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SyncfusionXamarinApp2
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc0NTcwQDMxMzcyZTMzMmUzME1Ybnd3WitCVlVlYmhrVmRxUnhDamFmZm90Q09UcTZ1R3hlUUFPbTIzS1U9");
            InitializeComponent();

            MainPage = new ChartSample();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
