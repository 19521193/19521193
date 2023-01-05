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
    public partial class SigupPage : ContentPage
    {
        public SigupPage()
        {
            InitializeComponent();
            var vm = BindingContext as SigupViewModel;
            if (vm != null)
            {
                vm.Navigation = Navigation;
            }
        }
    }
}