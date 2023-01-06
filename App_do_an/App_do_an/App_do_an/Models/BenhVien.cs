using SQLite;


namespace App_do_an.Models
{
    public class BenhVien
    {
        [PrimaryKey, AutoIncrement]
        public int id_benhVien { get; set; }
        public string Ten_BV { get; set; }
        public string suc_chua { get; set; }
        public string DiaChi_BV { get; set; }
        public string Img_BV { get; set; }
        public string color_bv { get; set; }
    }
    public class Khoa
    {
        [PrimaryKey, AutoIncrement]
        public int id_Khoa { get; set; }
        public int id_benhVien { get; set; }
        public string TenKhoa { get; set; }
        public string Mota { get; set; }
        public string Img_Khoa { get; set; }
    }
}
