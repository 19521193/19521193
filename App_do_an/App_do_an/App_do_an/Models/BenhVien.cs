using System;
using System.Collections.Generic;
using System.Text;
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
}
