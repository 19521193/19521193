using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace login.Model
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public string userName { get; set; }
        public string paswword { get; set; }
        public string Email { get; set; }
        public string RePassword { get; set; }


    }
}
