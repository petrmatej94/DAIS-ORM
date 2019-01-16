using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Vozidlo
    {
        public int Vid { get; set; }
        public string Vin { get; set; }
        public string Spz { get; set; }
        public string Znacka { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public string Barva { get; set; }
        public int Uid { get; set; }
        public Boolean Stav { get; set; }


        public override string ToString()
        {
            return Vid + " " + Vin + " " + Spz + " " + Znacka + " " + Model + " " + Typ + " " + Barva + " " + Uid + " " + Stav;
        }
    }
}
