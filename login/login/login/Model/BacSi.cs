using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace login.Model
{
    public class BacSi
    {
        [PrimaryKey, AutoIncrement]
        public int id_bs { get; set; }
        public string ten_bs { get; set; }
        public string khoa { get; set; }
        public string img_bs { get; set; }
        public int sdt_bs { get; set; }
    }
   

}
