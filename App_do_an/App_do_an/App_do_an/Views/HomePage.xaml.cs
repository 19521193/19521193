using App_do_an.Models;
using App_do_an.page;
using App_do_an.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_do_an.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage(UserModel data)
        {
            InitializeComponent();
        }
        private void ButDatlich_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DatLich());
        }
    }
}