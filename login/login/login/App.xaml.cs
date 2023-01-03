using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using login.Services;
using login.View;

namespace login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ILogin, loginServices>();
            MainPage = new NavigationPage(new LoginPage());
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
