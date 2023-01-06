<<<<<<< Updated upstream:login/login/login/App.xaml.cs
﻿using System;
=======
﻿using App_do_an.Models;
using App_do_an.Views;
using System;
>>>>>>> Stashed changes:App_do_an/App_do_an/App_do_an/App.xaml.cs
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using login.Services;
using login.View;

namespace login
{
    public partial class App : Application
    {
        public static LKDatabase LKDb = new LKDatabase();
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
