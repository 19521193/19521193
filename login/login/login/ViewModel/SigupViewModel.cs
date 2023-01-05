using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using login.Model;
using login.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace login.ViewModel
{
    public class SigupViewModel
    {
        private DatabaseService _database;
        public UserModel User { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand SignInCommand { get; set; }
        public INavigation Navigation { get; set; }
        public SigupViewModel()
        {
            _database = new DatabaseService();
            // do user chua duoc khoi tao
            User = new UserModel();
            RegisterCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.userName) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.paswword) || string.IsNullOrEmpty(User.RePassword))
                {
                    await App.Current.MainPage.DisplayAlert("Thông báo", "Nhập chưa đủ thông tin", "OK");
                }
                else
                {
                    // xu ly khi user dang ky tai khoan
                    if (await _database.RegisterAccount(User))
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Đăng ký tài khoản thành công", "OK");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Đăng ký tài khoản chưa thành công", "OK");
                    }
                }
            });
            SignInCommand = new Command(async () =>
            {
                await Navigation.PopAsync(true);
            });
        }
    }
}
