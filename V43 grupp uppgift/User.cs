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
        public string användarnamn { get; set; }
        public string lössenord { get; set; }

        public User (bool isadmin)
        {
                IsAdmin = isadmin;
        }
        public User (string anv,  string l)
        {
            användarnamn = anv;
            lössenord = l;
        }
    }

}   

