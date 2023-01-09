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
        //LKDatabase db;
        Khoa selectedkhoa;
        
        public DsLichKham(Khoa khoa)
        {
            InitializeComponent();
            Title = khoa.TenKhoa;
            selectedkhoa = khoa;
            CVInit(selectedkhoa);
            
        }

        void CVInit(Khoa khoa)
        {
            //LKDatabase db = new LKDatabase();
            //List<LichKham> listlichkham = new List<LichKham>();
            //listlichkham = db.GetCities(khoa);
            //CVLichKham.ItemsSource = listlichkham;
            CVLichKham.ItemsSource =App.LKdb.GetCities(khoa);
        }

        private void TbIAddLichKham_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new AddLichKham());
        }

        private void CVLichKham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private async void SwDelete_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var lichkham = swipeItem.CommandParameter as LichKham;
            LKDatabase db = new LKDatabase();
            bool answer = await DisplayAlert("Thông báo", $"Bạn có muốn xóa Lịch hẹn {lichkham.id_lk} không?", "Có", "Không");
            if (answer)
            {
                db.DeleteCity(lichkham);
                CVInit(selectedkhoa);
            }
        }
        private void SWEdit_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var lichkham = swipeItem.CommandParameter as LichKham;

            Navigation.PushAsync(new EditLichKham(lichkham));
        }
    }
}