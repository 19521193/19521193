using App_do_an.Models;
//using login.Model;
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
    public partial class DatLich : ContentPage
    {
        public DatLich()
        {
            InitializeComponent();
            List<BenhVien> list_bv = new List<BenhVien>
            {
               new BenhVien { id_benhVien = 1, Ten_BV = "Bệnh viện Chợ Rẫy", suc_chua = "6500", DiaChi_BV = "201B Đ. Nguyễn Chí Thanh, Phường 12, Quận 5, Thành phố Hồ Chí Minh", Img_BV = "https://lh3.googleusercontent.com/p/AF1QipN-0KLndxKFE4K3oZ-LIzo1XLHjiOSrj449fYbP=s1360-w1360-h1020", color_bv = "#F2E1C1" },
                new BenhVien { id_benhVien = 2, Ten_BV = "Bệnh viện Từ Dũ ", suc_chua = "2500", DiaChi_BV = "227 Cống Quỳnh, Phường Nguyễn Cư Trinh, Quận 1, Thành phố Hồ Chí Minh", Img_BV = "https://giupme.com/wp-content/uploads/2017/02/benh-vien-tu-du-284-cong-quynh-720x480.jpg", color_bv = "#F2E1C1" },
                new BenhVien { id_benhVien = 3, Ten_BV = "Bệnh viện Tâm Anh", suc_chua = "3150", DiaChi_BV = "2B Đ. P. Quang, Phường 2, Tân Bình, Thành phố Hồ Chí Minh", Img_BV = "https://lh3.googleusercontent.com/p/AF1QipPADn9P3KdRFEPuy6S9zoU22U8JDrWQ9O0Y4etL=s1360-w1360-h1020", color_bv = "#F2E1C1" },
                new BenhVien { id_benhVien = 4, Ten_BV = "Bệnh viện Nhi Đồng 2", suc_chua = "5000", DiaChi_BV = "14 Lý Tự Trọng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh", Img_BV = "https://lh3.googleusercontent.com/p/AF1QipPbKrZAdUhgXQ6RYXbzF3drIk906dhYWBfeS4kI=s1360-w1360-h1020", color_bv = "#F2E1C1" },
            };
            List_BenhVien.ItemsSource = list_bv;
        }
        private void SearchBar_Changed(object sender, TextChangedEventArgs e)
        {
            // List_BenhVien.ItemsSource = list_bv.Where(s => s.Ten_BV.ToLower().Contains(e.NewTextValue.ToLower()));
        }

        private void List_BenhVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                BenhVien location = (BenhVien)List_BenhVien.SelectedItem;
                Navigation.PushAsync(new DsKhoa(location));

                

        }
    }
}