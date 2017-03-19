using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Parcare
    {
        public string nrloc;
        public string timp;
        public string numeparcare;
        public string numeconducator;
        public string numarinmatriculare;
        public Parcare(string loc, string t, string np, string nc, string ni)
        {
            nrloc = loc;
            timp = t;
            numeparcare = np;
            numeconducator = nc;
            numarinmatriculare = ni;
        }
    }
}
