using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Pobocka
    {
        public int PobId { get; set; }
        public string Ulice { get; set; }
        public string Mesto { get; set; }
        public string Stat { get; set; }
        public string Typ { get; set; }
        public Boolean Stav { get; set; }


        public override string ToString()
        {
            return PobId + " " + Ulice + " " + Mesto + " " + Stat + " " + Typ + " " + Stav;
        }
    }
}
