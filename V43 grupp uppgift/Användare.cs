using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V43_grupp_uppgift
{
    internal class Användare
    {
        public string AnvändareNamn { get; set; }
        public string Lössenord { get; set; }

        public Användare(string namn, string lössen)
        {
            AnvändareNamn = namn;
            Lössenord = lössen;
        }
    }
}
