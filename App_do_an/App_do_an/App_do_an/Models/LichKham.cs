using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_do_an.Models
{
    public class LichKham
    {
        [PrimaryKey, AutoIncrement]
        public int id_lk { get; set; }
        public string TenKhoa { get; set; }
        public string Ten { get; set; }
        public string Tuoi { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Thoigian { get; set; }
        public string Mota { get; set; }

    }
}
