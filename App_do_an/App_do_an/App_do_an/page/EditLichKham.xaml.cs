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
    public partial class EditLichKham : ContentPage
    {
        //LKDatabase db = new LKDatabase();
        List<Khoalk> LkKhoa = new List<Khoalk>();
        List<TG> Tgs = new List<TG>();
        int idlkPicker;
        string TgPicker;
        LichKham _lichkham;
        public EditLichKham(LichKham lichkham )
        {

            InitializeComponent();
            Title = "Sửa Lịch hẹn khám bệnh";
            txtTen.Focus();
            _lichkham = lichkham;
            //thêm thời gian cho picker
            Tgs.Add(new TG
            {
                TgKham = "8 Giờ 30"
            });
            Tgs.Add(new TG
            {
                TgKham = "9 Giờ 30"
            });
            Tgs.Add(new TG
            {
                TgKham = "10 Giờ 30"
            });
            Tgs.Add(new TG
            {
                TgKham = "1 Giờ 30"
            });
            Tgs.Add(new TG
            {
                TgKham = "2 Giờ 30"
            });
            Tgs.Add(new TG
            {
                TgKham = "3 Giờ 30"
            });
            ThoiGianPicker.ItemsSource = Tgs;
            //thêm khoa cho picker
            LkKhoa.Add(new Khoalk
            {
                id_khoalk = 1,
                Tenkhoalk = "Khoa tim mạch"
            });
            LkKhoa.Add(new Khoalk
            {
                id_khoalk = 2,
                Tenkhoalk = "Khoa tai mũi họng"
            });
            LkKhoa.Add(new Khoalk
            {
                id_khoalk = 3,
                Tenkhoalk = "Khoa răng hàm mặt"
            });
            LkKhoa.Add(new Khoalk
            {
                id_khoalk = 4,
                Tenkhoalk = "Khoa khám bệnh"
            });
            KhoaPicker.ItemsSource = LkKhoa;
            //Dữ liệu ban đầu 
            
            txtTen.Text = lichkham.Ten;
            txtTuoi.Text = lichkham.Tuoi;
            txtGioiTinh.IsToggled = lichkham.GioiTinh;
            txtDiaChi.Text = lichkham.DiaChi;
            KhoaPicker.SelectedIndex = lichkham.id_lk;
            //ThoiGianPicker.SelectedIndex = lichkham.Thoigian;
            txtMoTa.Text = lichkham.Mota;
            
        }
        private void KhoaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedKhoa = KhoaPicker.SelectedIndex;
            idlkPicker = LkKhoa[selectedKhoa].id_khoalk;

        }
        private void ThoiGianPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTg = ThoiGianPicker.SelectedIndex;
            TgPicker = Tgs[selectedTg].TgKham;
        }
        private async void btnAddLichKham_Clicked(object sender, EventArgs e)
        {
            
            _lichkham.Ten = txtTen.Text;
            _lichkham.Tuoi = txtTuoi.Text;
            _lichkham.DiaChi = txtDiaChi.Text;
            _lichkham.id_khoa = idlkPicker;
            _lichkham.Thoigian = TgPicker;
            _lichkham.Mota = txtMoTa.Text;
            _lichkham.GioiTinh = txtGioiTinh.IsToggled;
            
            if (App.LKdb.UpdateCity(_lichkham))
            {
                await DisplayAlert("Thông báo", "Chỉnh sửa hẹn thành công", "Ok");
                await Navigation.PopAsync();

            }
            else
            {
                await DisplayAlert("Thông báo", "Chỉnh sửa lịch hẹn thất bại ", "Ok");

            }
            //Khoa khoa;
            
        }
    }
}