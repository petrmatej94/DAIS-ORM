using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Zaznam
    {
        public int Zazid { get; set; }
        public int Castka { get; set; }
        public int Odebrano_bodu { get; set; }
        public DateTime Datum_zadani { get; set; }
        public DateTime Datum_expirace { get; set; }
        public DateTime? Datum_provedeni { get; set; }
        public int Uid { get; set; }
        public int Zid { get; set; }
        public int Pid { get; set; }


        public string Jmeno { get; set; }
        public string Kategorie { get; set; }


        public override string ToString()
        {
            return Zazid + " " + Castka + " " + " " + Odebrano_bodu + Datum_zadani + " " + Datum_expirace + " " + Datum_provedeni 
                   + " " + Uid + " " + Zid + " " + Pid;
        }

        public string ToStringVypis()
        {
            return Zazid + " " + Castka + " " + Odebrano_bodu + " " + Datum_zadani + " " + Zid + " " + Jmeno + " " + Kategorie;
        }
    }
}
