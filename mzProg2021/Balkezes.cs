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
        public double elso { get; set; }
        public double utolso { get; set; }
        public double suly { get; set; }
        public double magassag { get; set; }

        public Balkezes(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            elso = double.Parse(s[1]);
            utolso = double.Parse(s[2]);
            suly = double.Parse(s[3]);
            magassag = double.Parse(s[4]);

        }
        public Balkezes()
        {
          
        }
    }

}
