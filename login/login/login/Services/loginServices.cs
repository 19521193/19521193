using System;
using System.Collections.Generic;
using System.Text;
using login.Model;
namespace login.Services
{
    public class loginServices : ILogin
    {
        List<UserModel> userList = new List<UserModel>();
        public loginServices()
        {
            userList.Add(new UserModel { userName = "user1", paswword = "12345" });
            userList.Add(new UserModel { userName = "user2", paswword = "6789" });
        }
        public bool login(string userName, string password)
        {
            foreach(var user in userList)
            {
                if(userName==user.userName & password==user.paswword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
