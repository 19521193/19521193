using App_do_an.Models;
using App_do_an.Services;
using App_do_an.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_do_an.ViewModels
{
    public class LoginViewModel
    {
        private DatabaseService _database;
        public UserModel User { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand SigupCommand { get; set; }
        public INavigation Navigation { get; set; }
        public LoginViewModel()
        {
            _database = new DatabaseService();
            User = new UserModel();
            LoginCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Thông báo", "Điền đầy đủ thông tin", "OK");
                }
                else
                {
                    // xu ly logic khi dang nhap
                    var data = await _database.Login(User);
                    if (data != null)
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
                        await Navigation.PushAsync(new HomePage(data), true);
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Tài khoản hoặc mật khảu sai", "OK");
                    }
                }
            });
            SigupCommand = new Command(Sigup);
        }

        private async void Sigup()
        {
            await Navigation.PushAsync(new SigupPage(), true);
        }
    }
}
