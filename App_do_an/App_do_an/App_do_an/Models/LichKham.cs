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
        public int id_khoa { get; set; }
        public string Mota { get; set; }
        public string tg { get; set; }

    }
}
