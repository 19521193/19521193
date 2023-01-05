using login.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class createAcc : ContentPage
    {
        public createAcc()
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