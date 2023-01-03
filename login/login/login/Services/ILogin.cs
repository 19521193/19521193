using System;
using System.Collections.Generic;
using System.Text;

namespace login.Services
{
    public interface ILogin
    {
        bool login(string userName, string password);
    }
}
