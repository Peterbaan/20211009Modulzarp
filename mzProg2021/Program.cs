using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace mzProg2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("balkezesek.csv");
            List<Balkezes> balkezesek = new List<Balkezes>();
            foreach (string sor in sorok.Skip(1))
            {
                balkezesek.Add(new Balkezes());
            }

            int N = balkezesek.Count;//1. Feladat
            Console.WriteLine($"{N} db balkezes játékos van.");

            int Db1980Felett= 0;
            for (int i = 0; i < N; i++) { if (Elso == 1980) { Db1980Felett++; } }
            Console.WriteLine($"2. Feladat: {Db1980Felett} veresenyző lépett 1980-ban pályára először");

            Console.WriteLine(N);

            Console.ReadLine();
        }
    }
}
