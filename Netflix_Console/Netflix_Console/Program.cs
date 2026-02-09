namespace Netflix_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(path: "netflix_movies.csv");
            List<Netflix> netflixBeolvas = new List<Netflix>();
            foreach (string line in lines.Skip(1))
            {
                string[] lineParts = line.Split(";");
                Netflix netflix = new Netflix(
                    azon: int.Parse(lineParts[0]),
                    cím: lineParts[1],
                    rendezo: lineParts[2],
                    hozzadas_datum: DateTime.Parse(lineParts[3]),
                    ertekeles: double.Parse(lineParts[4]),
                    nyelv: lineParts[5]
                    );
                netflixBeolvas.Add( netflix );
            }
            Console.WriteLine("2. Feladat: Beolvasva");

            Console.WriteLine($"3.feladat: A forrásfájl {netflixBeolvas.Count} sort tartalmaz");

            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach(Netflix ny in netflixBeolvas)
            {
                if (stat.ContainsKey(ny.Nyelv))
                {
                    stat[ny.Nyelv]++;
                }
                else
                {
                    stat.Add(ny.Nyelv, 1);
                }
            }
            Console.WriteLine("4.feladat");
            foreach (var elem in stat)
            {
                Console.WriteLine($"{elem.Key}: {elem.Value} db");
            }

            double atlag = netflixBeolvas.Where(r => r.Rendezo == string.Empty).Average(r => r.Ertekeles);
            double atlagKerek = Math.Round(atlag,2);

            Console.WriteLine($"5. feladat: Rendező nélkül filmek átlag értékelése: {atlagKerek}");

            Console.Write("Adjon meg egy évszámot: ");
            int evszam = int.Parse(Console.ReadLine());
            List<string> outputLines = new List<string>();


            foreach(Netflix netflix in netflixBeolvas)
            {
                if(netflix.Hozzadas_datum.Year == evszam)
                {
                    outputLines.Add($"{netflix.Azon};{netflix.Cím}; {netflix.Rendezo};{netflix.Hozzadas_datum.ToString("yyyy/MM/dd")};{netflix.Ertekeles};{netflix.Nyelv}");
                }
            }
            if(outputLines.Count == 0)
            {
                Console.WriteLine("A beírt évhez nem tartozik film");
            }
            File.WriteAllLines($"{evszam}_legjobb.csv",outputLines);
            Console.WriteLine("A fájlba írás kész");
        }
    }
}
