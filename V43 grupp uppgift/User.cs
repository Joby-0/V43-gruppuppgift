using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V43_grupp_uppgift
{
    internal class User
    {
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User (bool isadmin, string userName, string password)
        {
            IsAdmin = isadmin;
            UserName = userName;
            Password = password;
        }
    }

}   

