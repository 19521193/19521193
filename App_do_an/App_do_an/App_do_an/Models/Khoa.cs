using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_do_an.Models
{
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
