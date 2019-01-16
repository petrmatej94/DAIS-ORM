using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Ridic
    {
        public int Uid { get; set; }
        public string Jmeno { get; set; }
        public string Ulice { get; set; }
        public string Mesto { get; set; }
        public string Stat { get; set; }
        public string Obcanstvi { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public int Pocet_bodu { get; set; }
        public int Cislo_rp { get; set; }
        public DateTime Platnost_rp { get; set; }
        public Boolean Stav { get; set; }

        public override string ToString()
        {
            return Uid + " " + Jmeno + " " + Ulice + " " + Mesto + " " + Stat + " " + Obcanstvi + 
                   " " + Datum_narozeni + " " + Pocet_bodu + " " + Cislo_rp + " " + Platnost_rp + " " + Stav;
        }
    }
}
