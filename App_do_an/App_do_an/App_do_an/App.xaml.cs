using App_do_an.Models;
using App_do_an.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_do_an
{
    public partial class App : Application
    {
        public static LKDatabase LKdb = new LKDatabase();
        public App()
        {
            InitializeComponent();
            //LKDatabase db = new LKDatabase();
            //db.CreateDatabase();

            MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.FromHex("#1e81b0"),
                BarTextColor = Color.White,
            };
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
