namespace netflix_Nemeth_Koppany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(path: "netflix_movies.csv");
            List<Netflix> netflixes = new List<Netflix>();
            foreach(string line in lines.Skip(1))
            {
                string[] lineParts = line.Split(";");
                Netflix netflix = new Netflix(
                    azon: int.Parse(lineParts[0]),
                    cím: lineParts[1],
                    rendezo: lineParts[2],
                    hozzaadas_datuma:  DateTime.Parse(lineParts[3]),
                    ertekeles: double.Parse(lineParts[4]),
                    nyelv: lineParts[5]
                    );
                netflixes.Add( netflix );
            }
            Console.WriteLine("2. Feladat: Fájl beolvasása...kész");
            Console.WriteLine($"3. feladat: A forrásfájl {netflixes.Count} adatsort tartalmaz");

            int en = 0;
            int de = 0;
            int pl = 0;
            int hu = 0;
            int ro = 0;

            for (int i = 0; i < netflixes.Count; i++)
            {
                if (netflixes[i].Nyelv == "en")
                {
                    en++;
                }
                else if(netflixes[i].Nyelv == "de")
                {
                    de++;
                }
                else if(netflixes[i].Nyelv == "pl")
                {
                    pl++;
                }
                else if(netflixes[i].Nyelv == "hu")
                {
                    hu++;
                }
                else if(netflixes[i].Nyelv == "ro")
                {
                    ro++;
                }
            }

            Console.WriteLine($"4.feladat: \n en: {en} db \n de: {de} db \n pl: {pl} db \n hu: {hu} db \n ro: {ro} db");

            double atlag = netflixes.Where(r => r.Rendezo == string.Empty).Average(r => r.Ertekeles);
            double atlagKerek = Math.Round(atlag, 2);
            
            Console.WriteLine($"5. Feladat: Rendező nélküli filmek átlagos értékelése: {atlagKerek}");

            Console.WriteLine("6. Feladat: Kérek egy évszámot:");
            int evszam = int.Parse(Console.ReadLine());
            List<string> outputLines = new List<string>();
            foreach (Netflix netflix in netflixes)
            {
                if(netflix.Hozzaadas_datuma.Year == evszam)
                {
                    outputLines.Add($"{netflix.Azon};{netflix.Cím};{netflix.Rendezo};{  netflix.Hozzaadas_datuma.ToString("yyyy/MM/dd")};{netflix.Ertekeles};{netflix.Nyelv}");
                }
            }
            if(outputLines.Count == 0)
            {
                Console.WriteLine("A beírt évhez nem tartozik egyetlen film sem!");
            } 
            File.WriteAllLines($"{evszam}_legjobb.csv",outputLines);
            Console.WriteLine("Fájlba írás kész!");
        }
    }
}
