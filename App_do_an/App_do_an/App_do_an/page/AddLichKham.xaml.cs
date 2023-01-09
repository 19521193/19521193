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
        List<Khoalk> LkKhoa = new List<Khoalk>();
        List<TG> Tgs = new List<TG>();
        int idlkPicker;
        string TgPicker;
        public AddLichKham()
        {
            InitializeComponent();
            Title = "Thêm Lịch hẹn khám bệnh";
            txtTen.Focus();
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
                id_khoalk= 1,
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
            KhoaPicker.ItemsSource=LkKhoa;


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
            LichKham newlichkham = new LichKham();
            newlichkham.Ten = txtTen.Text;
            newlichkham.Tuoi = txtTuoi.Text;
            newlichkham.DiaChi = txtDiaChi.Text;
            newlichkham.id_khoa = idlkPicker;
            newlichkham.Thoigian = TgPicker;
            newlichkham.Mota = txtMoTa.Text;
            newlichkham.GioiTinh = txtGioiTinh.IsToggled;
            //LKDatabase db = new LKDatabase();
            if (App.LKdb.AddnewCity(newlichkham))
            //if (db.AddnewCity(newlichkham))
            {
                await DisplayAlert("Thông báo", "Đặt lịch hẹn thành công", "Ok");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Thông báo", "Đặt lịch hẹn thất bại ", "Ok");

            }
            //Khoa khoa;
            
        }

      
    }
}