using System.Linq;
using Kalapcsvetes;

namespace Kalapacsvetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(path: "kalapacsvetes.txt");
            List<Sportolo> sportolok = new List<Sportolo>();
            foreach (string line in lines.Skip(1))
            {
                string[] lineParts = line.Split(';');
                Sportolo sportolo = new Sportolo(
                    helyezes: int.Parse(lineParts[0]),
                    eredmeny: double.Parse(lineParts[1]),
                    nev: lineParts[2],
                    orszagkod: lineParts[3],
                    helyszin: lineParts[4],
                    datum: DateTime.Parse(lineParts[5]));
                sportolok.Add(sportolo);
            }

            Console.WriteLine($"4. feladat: {sportolok.Count} dobás eredménye található.");

            double atlag = sportolok.Where(s => s.Orszagkod == "HUN").Average(s => s.Eredmeny);
            Console.WriteLine($"5. feladat: A magyar sportolók átlagosan {Math.Round(atlag, 2)} métert dobtak.");

            Console.WriteLine("6. feladat: Adjon meg egy évszámot:");
            int evszam = int.Parse(Console.ReadLine());
            List<string> nevek = sportolok.Where(s => s.Datum.Year == evszam).Select(s => s.Nev).ToList();
            if (nevek.Count == 0)
            {
                Console.WriteLine("Egy dobás sem került be ebben az évben.");
            }
            else
            {
                Console.WriteLine($"{nevek.Count} darab dobás került be ebben az évben.");
                foreach (string nev in nevek)
                {
                    Console.WriteLine($"\t{nev}");
                }
            }

            Dictionary<string, int> dobasokSzama = new Dictionary<string, int>();
            foreach (Sportolo sportolo in sportolok)
            {
                if (!dobasokSzama.ContainsKey(sportolo.Orszagkod))
                {
                    dobasokSzama[sportolo.Orszagkod] = 1;
                }
                else
                {
                    dobasokSzama[sportolo.Orszagkod]++;
                }
            }

            Console.WriteLine("7. feladat: Statisztika");
            foreach (string orszagkod in dobasokSzama.Keys)
            {
                Console.WriteLine($"\t{orszagkod} - {dobasokSzama[orszagkod]} dobás");
            }

            List<string> outputLines = new List<string>();
            foreach (Sportolo sportolo in sportolok)
            {
                if (sportolo.Orszagkod == "HUN")
                {
                    outputLines.Add($"{sportolo.Helyezes};{sportolo.Eredmeny};{sportolo.Nev};{sportolo.Orszagkod};{sportolo.Helyszin};{sportolo.Datum}");
                }
            }

            File.WriteAllLines("magyarok.txt", outputLines);
        }
    }
}