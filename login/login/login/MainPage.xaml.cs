using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using login.View;

namespace login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void datlich_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DatLich());
        }
    }
}
