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

        public User (bool isadmin)
        {
                IsAdmin = isadmin;
        }
    }

}   

