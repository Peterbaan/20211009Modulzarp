using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mzProg2021
{
    class Balkezes
    {
        public string nev { get; set; }
        public int elso { get; set; }
        public int utolso { get; set; }
        public int suly { get; set; }
        public int magassag { get; set; }

        public Balkezes(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            elso = int.Parse(s[1]);
            utolso = int.Parse(s[2]);
            suly = int.Parse(s[3]);
            magassag = int.Parse(s[4]);
        }
        public Balkezes()
        {
        }
    }

}
