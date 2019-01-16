using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Skupina
    {
        public int Kid { get; set; }
        public string skupina { get; set; }
        public string Popis { get; set; }


        public override string ToString()
        {
            return Kid + " " + skupina + " " + Popis;
        }
    }
}
