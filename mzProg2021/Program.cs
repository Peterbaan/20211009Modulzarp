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
                balkezesek.Add(new Balkezes(sor));
            }

            //1. Feladat
            int N = balkezesek.Count;
            Console.WriteLine($"1. Feladat: {N} db balkezes játékos van.");

            //2. Feladat
            int Db1980Felett = 0;
            foreach (Balkezes balkezes in balkezesek)
            {
                if (19800101 <= balkezes.elso && balkezes.elso <= 19801231)
                {
                    Db1980Felett++;
                }
            }
            Console.WriteLine($"2. Feladat: {Db1980Felett} veresenyző lépett 1980-ban pályára először");

            //3. Feladat
            double inch = 2.54;
            double magassagCm = 0;
            Console.WriteLine("Adjon meg egy nevet!");
            string nevBekeres = Console.ReadLine();

            foreach (Balkezes balkezes in balkezesek)
            {
                if (balkezes.nev == nevBekeres)
                {
                    magassagCm = balkezes.magassag * inch;
                    Console.WriteLine($"3. Feladat: A bekért {nevBekeres} nevű játékos magassága: {Math.Round(magassagCm, 1)}"); //3.Feladat
                }
                else
                {
                    Console.WriteLine("Hibás adat! Próbálja újra!");
                    Console.ReadLine();
                }
            }

            //4.Feladat
            Console.WriteLine("Adjon meg egy évszámot 1900 és 1999 között!");
            double Bekeres = double.Parse(Console.ReadLine() + 0101);
            if (19000101 <= Bekeres && Bekeres <= 19991231)
            {
                Console.WriteLine("Helyes adat");
                List<Balkezes> bekertBalkezes = new List<Balkezes>();
                foreach (Balkezes balkezes in balkezesek)
                {
                    if (balkezes.elso == Bekeres)
                    {
                        bekertBalkezes.Add(balkezes);

                    }
                }
                bekertBalkezes.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Hibás adat, adja meg újra!");
                Console.ReadLine();
            }

            //5.Feladat
            int minIndex = 0;
            for (int i = 1; i < N; i++)
            {

                if (balkezesek[i].elso < balkezesek[minIndex].elso)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"5. Feladat: a legkorábban {balkezesek[minIndex]} évben léptek pályára.");

            //6.Feladat
            int j = 0;
            while (j < N && balkezesek[j].utolso <= 20000101) { j++; }
            bool van = j >= N;
            if (van == true)
            {
                Console.WriteLine("6. Feladat: Van, aki 2000 után lépett pályára.");
            }
            else
            {
                Console.WriteLine("6. Feladat: Nincs aki 2000 után lépett volna pályára.");
            }

            //7. Feladat
            List<string> vanEJohn = new List<string>();
            foreach (Balkezes balkezes in balkezesek)
            {
                if (balkezes.nev.Contains("John"))
                {
                    vanEJohn.Add($"{balkezes.nev}\n"); 
                }
            }
            int johnDb = vanEJohn.Count;
            Console.WriteLine($"7. Feladat: John-ból van {johnDb}, ezek a következők:");
            vanEJohn.ForEach(Console.WriteLine);

            //8. Feladat
            string fn = "kernevek.txt";
            List<string> kernev = new List<string>();
            foreach (Balkezes balkezes in balkezesek)
            {
                if (balkezes.nev.Contains("Joe") || balkezes.nev.Contains("John") || balkezes.nev.Contains("Jim") || balkezes.nev.Contains("Jack"))
                {
                    kernev.Add($"{balkezes.nev}\n");
                }
            }
            File.WriteAllLines(fn, kernev.ToArray());

            Console.ReadLine();
        }
    }
}
