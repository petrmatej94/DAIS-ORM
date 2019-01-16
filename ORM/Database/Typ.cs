using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Typ
    {
        public int Pid { get; set; }
        public string Kategorie { get; set; }
        public string Popis { get; set; }
        public int Maximalni_vyse { get; set; }
        public int Bodovy_trest { get; set; }
        public Boolean Stav { get; set; }


        public override string ToString()
        {
            return Pid + " " + Kategorie + " " + Popis + " " + Maximalni_vyse + " " + Bodovy_trest + " " + Stav;
        }
    }
}
