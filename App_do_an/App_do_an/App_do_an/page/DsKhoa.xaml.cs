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
    public partial class DsKhoa : ContentPage
    {
        public DsKhoa(BenhVien location)
        {
            InitializeComponent();
            Title = location.Ten_BV;
            CreateListKhoa(location);
        }
        List<Khoa>LKhoa=new List<Khoa>();
        private void CreateListKhoa(BenhVien location)
        {
            if (location.id_benhVien.Equals(1))
            {
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 1,
                    id_benhVien = 1,
                    TenKhoa = "Tim Mạch",
                    Img_Khoa = "https://cih.com.vn/images/09.2019/tim-mach-1.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 2,
                    id_benhVien = 1,
                    TenKhoa = "Tai mũi họng",
                    Img_Khoa = "https://khamtaimuihong.vn/wp-content/uploads/2019/07/tai-mui-hong-fa.jpg"
                }); 
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 3,
                    id_benhVien = 1,
                    TenKhoa = "Răng hàm mặt ",
                    Img_Khoa = "https://benhviendongdo.com.vn/wp-content/uploads/2018/04/icon-rang-ham-mat.png"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 4,
                    id_benhVien = 1,
                    TenKhoa = "Khám bệnh",
                    Img_Khoa = "https://logoart.vn/blog/wp-content/uploads/2013/03/thiet-ke-logo-tam-y-te.jpg"
                });
            }
            else if (location.id_benhVien.Equals(2))
            {
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 1,
                    id_benhVien = 2,
                    TenKhoa = "Tim Mạch",
                    Img_Khoa = "https://cih.com.vn/images/09.2019/tim-mach-1.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 2,
                    id_benhVien = 2,
                    TenKhoa = "Tai mũi họng",
                    Img_Khoa = "https://khamtaimuihong.vn/wp-content/uploads/2019/07/tai-mui-hong-fa.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 3,
                    id_benhVien = 2,
                    TenKhoa = "Răng hàm mặt ",
                    Img_Khoa = "https://benhviendongdo.com.vn/wp-content/uploads/2018/04/icon-rang-ham-mat.png"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 4,
                    id_benhVien = 2,
                    TenKhoa = "Khám bệnh",
                    Img_Khoa = "https://logoart.vn/blog/wp-content/uploads/2013/03/thiet-ke-logo-tam-y-te.jpg"
                });

            }
            else if (location.id_benhVien.Equals(3))
            {
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 1,
                    id_benhVien = 3,
                    TenKhoa = "Tim Mạch",
                    Img_Khoa = "https://cih.com.vn/images/09.2019/tim-mach-1.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 2,
                    id_benhVien = 3,
                    TenKhoa = "Tai mũi họng",
                    Img_Khoa = "https://khamtaimuihong.vn/wp-content/uploads/2019/07/tai-mui-hong-fa.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 3,
                    id_benhVien = 3,
                    TenKhoa = "Răng hàm mặt ",
                    Img_Khoa = "https://benhviendongdo.com.vn/wp-content/uploads/2018/04/icon-rang-ham-mat.png"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 4,
                    id_benhVien = 3,
                    TenKhoa = "Khám bệnh",
                    Img_Khoa = "https://logoart.vn/blog/wp-content/uploads/2013/03/thiet-ke-logo-tam-y-te.jpg"
                });
            }
            else if (location.id_benhVien.Equals(4))
            {
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 1,
                    id_benhVien = 4,
                    TenKhoa = "Tim Mạch",
                    Img_Khoa = "https://cih.com.vn/images/09.2019/tim-mach-1.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 2,
                    id_benhVien = 4,
                    TenKhoa = "Tai mũi họng",
                    Img_Khoa = "https://khamtaimuihong.vn/wp-content/uploads/2019/07/tai-mui-hong-fa.jpg"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 3,
                    id_benhVien = 4,
                    TenKhoa = "Răng hàm mặt ",
                    Img_Khoa = "https://benhviendongdo.com.vn/wp-content/uploads/2018/04/icon-rang-ham-mat.png"
                });
                LKhoa.Add(new Khoa
                {

                    id_Khoa = 4,
                    id_benhVien = 4,
                    TenKhoa = "Khám bệnh",
                    Img_Khoa = "https://logoart.vn/blog/wp-content/uploads/2013/03/thiet-ke-logo-tam-y-te.jpg"
                });
            }
            LDsKhoa.ItemsSource = LKhoa;
        }
        private void LDsKhoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Khoa khoa = (Khoa)LDsKhoa.SelectedItem;
            //Navigation.PushAsync(new AddLichKham(khoa));
        }
    }
}