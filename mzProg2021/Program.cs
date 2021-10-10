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

            int N = balkezesek.Count;
            Console.WriteLine($"{N} db balkezes játékos van.");//1. Feladat


            //int Db1980Felett = 0;
            //foreach (Balkezes balkezes in balkezesek)
            //{
            //    if (balkezes.elso == 1980)
            //    {
            //        Db1980Felett++;
            //    }
            //}
            //for (int i = 0; i < N; i++) { if (balkezesek.elso == 1980) { Db1980Felett++; } }
            //Console.WriteLine($"2. Feladat: {Db1980Felett} veresenyző lépett 1980-ban pályára először"); //2. Feladat



            double inch = 2.54;
            double magassagCm = 0;
            Console.WriteLine("Adjon meg egy nevet!");
            string nevBekeres = Console.ReadLine();

            //foreach (Balkezes balkezes in balkezesek)
            //{
            //    if (balkezes.nev==nevBekeres)
            //    {
            //        magassagCm = balkezes.magassag * inch;
            //        Console.WriteLine($"3. Feladat: A bekért {nevBekeres} nevű játékos magassága: {Math.Round(magassagCm,1)}"); //3.Feladat
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hibás adat! Próbálja újra!");
            //        Console.ReadLine();
            //    }
            //}

            Console.WriteLine("Adjon meg egy évszámot 1900 és 1999 között!");
            int Bekeres = int.Parse(Console.ReadLine());
            //if (1900 <= Bekeres && Bekeres <= 1999)
            //{
            //    Console.WriteLine("Helyes adat");
            //    List<Balkezes> bekertBalkezes = new List<Balkezes>();
            //    string[] sorok2 = Bekeres == Balkezes.elso;
            //    foreach (string sor in sorok2.Skip(1))
            //    {
            //        bekertBalkezes.Add(new Balkezes());
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hibás adat, adja meg újra!");
            //    Console.ReadLine(); //4.Feladat
            //}

            int minIndex = 0;
            for (int i = 1; i < N; i++)
            {

                if (balkezesek[i].elso < balkezesek[minIndex].elso)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"5. Feladat: a legkorábban {balkezesek[minIndex]} évben léptek pályára.");

            int j = 0;
            while (j < N && balkezesek[j].utolso<2000) { j++; }
            bool van = j < N;
            if (van ==true)
            {
                Console.WriteLine("6. Feladat: Van, aki 2000 után lépett pályára.");
            }
            else
            {
                Console.WriteLine("6. Feladat: Nincs aki 2000 után lépett volna pályára.");
            }


            Console.ReadLine();
        }

    }
}
