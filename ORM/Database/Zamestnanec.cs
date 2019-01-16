using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Zamestnanec
    {
        public int Zid { get; set; }
        public string Jmeno { get; set; }
        public string Hodnost { get; set; }
        public int Pobid { get; set; }
        public Boolean Stav { get; set; }


        public int PocetPokut { get; set; }


        public override string ToString()
        {
            return Zid + " " + Jmeno + " " + Hodnost + " " + Pobid + " " + Stav;
        }

        public string ToString2()
        {
            return Zid + " " + Jmeno + " " + PocetPokut;
        }
    }
}
