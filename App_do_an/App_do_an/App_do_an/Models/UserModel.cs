using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App_do_an.Models
{
    public class UserModel
    {
        [PrimaryKey]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
