using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using login.View;
using login.Services;
using System.Linq;
using System.Threading.Tasks;

namespace login.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command cmdLogin { get; set;}
        public Command cmdcreateAcc { get; set; }
        public Command cmdForgotPassword { get; set; }

        ILogin ilog = DependencyService.Get<ILogin>();
        public LoginViewModel()
        {
             cmdLogin = new Command(gotoMainPage);
             cmdcreateAcc = new Command(gotocreateAcc);
             cmdForgotPassword = new Command(gotoForgotPassword);
        }
        private void gotoMainPage(object obj)
        {
            if (ilog.login(UserName, Password))
            {
                App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                LoginMessa = "Please enter a vaild User Name and Password!";
                TurnLoginMessa = true;
            }
        }
        private void gotoForgotPassword(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new ForgotPassword());
        }

        private void gotocreateAcc(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new createAcc());
        }
        //----
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new  PropertyChangedEventArgs("Password"));
            }
        }
        private string loginMessa;
        public string LoginMessa
        {
            get { return loginMessa; }
            set
            {
                loginMessa = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginMessa"));
            }
        }
        private bool turnLoginMessa = false;
        public bool TurnLoginMessa
        {
            get { return turnLoginMessa; }
            set
            {
                turnLoginMessa = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessa"));
            }
        }

        public INavigation Navigation { get; internal set; }
    }
    

}
