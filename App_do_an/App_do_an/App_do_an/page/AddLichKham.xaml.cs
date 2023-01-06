using App_do_an.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_do_an.page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddLichKham : ContentPage
    {
        LichKham lk;
        public AddLichKham()
        {
            InitializeComponent();
            Title = "Thêm Lịch hẹn khám bệnh";
        }
      
        public AddLichKham(LichKham lichkham)
        {
            InitializeComponent();
            Title = "Sửa Lịch hẹn";
            lk = lichkham;
            txtTen.Text = lichkham.Ten;
            txtTuoi.Text = lichkham.Tuoi;
            txtDiaChi.Text = lichkham.DiaChi;
            txtThoiGian.Text = lichkham.Thoigian;
            txtMoTa.Text = lichkham.Mota;

        }

        private async void btnAddLichKham_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtTuoi.Text)
                || string.IsNullOrEmpty(txtTuoi.Text)
                || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(txtThoiGian.Text))
                
            {
                await DisplayAlert("Thông báo", "Vui lòng điền đầy đủ thông tin!", "Đóng");
            }
            else if (lk != null)
            {
                lk.Ten = txtTen.Text;
                lk.Tuoi = txtTuoi.Text;
                lk.DiaChi = txtDiaChi.Text;
                lk.Thoigian = txtThoiGian.Text;
                lk.Mota = txtMoTa.Text;
                if (txtNam.IsChecked)
                {
                    lk.GioiTinh = true;
                }
                else
                    lk.GioiTinh = false;

                App.BookingDb.UpdateCity(_city);
                await Navigation.PopAsync();
            }
            else
            {
                City city = new City()
                {
                    CityName = txtCityName.Text,
                    CityImageUrl = txtCityImg.Text
                };

                if (App.BookingDb.CreateCity(city))
                {
                    await DisplayAlert("Thông báo", "Thêm mới thành công!", "Cancel");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Thông báo", "Thêm mới thất bại!", "Cancel");
                }
            }
        }
    }
}