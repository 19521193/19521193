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
    public partial class DsLichKham : ContentPage
    {
        Khoakham kk;
        public DsLichKham(Khoakham Selectedkk)
        {
            InitializeComponent();
            Title = kk.TenKhoa;
            kk = Selectedkk;
            createKK(kk);
        }
        List<Khoakham> Dskk = new List<Khoakham>();
        //lấy tên khoa từ khoa khám
        public void createKK(Khoakham khoakham)
        {
            Dskk.Add(khoakham);
            CVDsLK.ItemsSource =  Dskk;
        }
        /*protected override void OnAppearing()
        {
            base.OnAppearing();
            CVDsLK.ItemsSource = App.LKDb.ReadLichKham();
        }*/
        private void TIAddlk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddLichKham());
        }
        private async void SWDelete_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var lichkham = swipeItem.CommandParameter as LichKham;
            var khoakham = swipeItem.CommandParameter as Khoakham;

            bool answer = await DisplayAlert("Thông báo", $"Bạn có muốn xóa lịch hẹn {khoakham.TenKhoa} lúc {lichkham.Thoigian} không?", "Có", "Không");
            if (answer)
            {
                App.LKDb.DeleteLichKham(lichkham);
                CVDsLK.ItemsSource = App.LKDb.ReadLichKham();
            }
        }
        private void SWEdit_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var lichkham = swipeItem.CommandParameter as LichKham;

            Navigation.PushAsync(new AddLichKham(lichkham));
        }
    }
}