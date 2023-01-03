using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatLich : ContentPage
    {
        public DatLich()
        {
            InitializeComponent();
            List<BacSi> list_bs = new List<BacSi>
            {
                new BacSi{id_bs=1, ten_bs="Nguyễn Văn A",khoa="tim mạch", img_bs="https://cdn.bookingcare.vn/fr/w800/2017/12/23/154455bac-si.jpg",sdt_bs=012345},
                new BacSi{id_bs=2, ten_bs="Hoàng Văn B",khoa="thần kinh", img_bs="https://tse1.mm.bing.net/th?id=OIP.gbW4Rg_APSwNoyHdR8A6_wHaE8&pid=Api&P=0",sdt_bs=052532856},
                new BacSi{id_bs=3, ten_bs="Phan Văn C",khoa="sản", img_bs="https://bookingcare.vn/files/image/2019/03/27/143524bs-vu-thai-ha.jpg",sdt_bs=02356922},
                new BacSi{id_bs=4, ten_bs="Võ Ngọc D",khoa="Da liễu", img_bs="https://thuocdantoc.vn/wp-content/uploads/2018/12/phong-kham-tai-mui-hong-bac-si-huynh-anh-1.jpg",sdt_bs=0292578},
            };
            List_bacsi.ItemsSource = list_bs;
        }
    }
}