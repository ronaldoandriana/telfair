using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Telfair.Services;
using Telfair.Views;

namespace Telfair
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Telfair.Views.Auth.LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
