using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class RidicovySkupiny
    {
        public int Uid { get; set; }
        public int Kid { get; set; }


        public override string ToString()
        {
            return Uid + " " + Kid;
        }
    }
}
