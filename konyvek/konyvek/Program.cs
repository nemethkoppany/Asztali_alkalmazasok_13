namespace konyvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            string[] sorok = File.ReadAllLines("kiadas.txt");
            List<Kiadas> kiadasok= new List<Kiadas>();
            foreach(string sor in sorok)//.skip(1) kell ha van a beolvasott fájlnak fejléce
            {
                kiadasok.Add(new Kiadas(sor));
            }

            //2.feladat
            Console.WriteLine("2. feladat:");
            Console.Write("Szerő: ");
            string szerzo = Console.ReadLine();
            int kiadasok_szama = kiadasok.Count(k => k.Leiras.StartsWith(szerzo));
            if(kiadasok_szama > 0)
            {
                Console.WriteLine($"{kiadasok_szama} kiadás");
            }
            else
            {
                Console.WriteLine("Nem adta ki");
            }

            //3.feladat
            Console.Write("3.feladat:");

            //int legnagyobbPeldanyszam = kiadasok.Select(k => k.Peldanyszam).Max();
            //int elofordulasok = kiadasok.Where(k => k.Peldanyszam == legnagyobbPeldanyszam).Count();
            int legnagyobbPeldanyszam = kiadasok.Max(k => k.Peldanyszam);
            int elofodulasok = kiadasok.Count(k => k.Peldanyszam == legnagyobbPeldanyszam);
            Console.WriteLine($"Leganyobb példányszám: {legnagyobbPeldanyszam} előfordult {elofodulasok} alkalommal");

            //4.feladat
            Console.WriteLine("4.feladat: ");

            Kiadas keresettKiadas = kiadasok.Where(k => k.Eredet == "kf").Where(k => k.Peldanyszam >= 40000).First();

            Console.WriteLine($"{keresettKiadas.Evszam}/{keresettKiadas.Negyedev}. {keresettKiadas.Leiras}");

            //5.feladat
            Console.WriteLine("5.feladat: ");

            Dictionary<int, Statisztika> statisztika = new Dictionary<int, Statisztika>();
            for (int evszam = 2020; evszam <= 2023; evszam++)
            {
                statisztika[evszam] = new Statisztika { MagyarKiadas = 0, MagyarPeldanyszam = 0, KulfoldiKiadas = 0, KulfoldiPeldanyszam = 0 }; 
                
            }
            foreach(Kiadas kiadas in kiadasok)
            {
                Statisztika stat = statisztika[kiadas.Evszam];
                if(kiadas.Eredet == "ma")
                {
                    stat.MagyarKiadas++;
                    stat.MagyarPeldanyszam+= kiadas.Peldanyszam;
                }
                else
                {
                    stat.KulfoldiKiadas++;
                    stat.KulfoldiPeldanyszam += kiadas.Peldanyszam;
                }
            }
            List<string> tablasorok = new List<string>();
            tablasorok.Add("<table>");
            tablasorok.Add("<tr><th>Év</th><th>Magyar kiadás</th><th>Magyar példányszám</th><th>Külföldi");

            Console.WriteLine($"Év \t \t Magyar kiadás \t \t Magyar példányszám \t \t Külföldi kiadás \t \t Külföldi példányszám");
            foreach(var (evszam,stat) in statisztika)
            {
                
                Console.WriteLine($"{evszam} \t {stat.MagyarKiadas}\t {stat.MagyarPeldanyszam}\t {stat.KulfoldiKiadas} \t {stat.KulfoldiPeldanyszam}");
                tablasorok.Add($"<tr><th>{evszam}</th><th>{stat.MagyarKiadas}</th><th>{stat.MagyarPeldanyszam}</th><th>{stat.KulfoldiKiadas}</th><th>{stat.KulfoldiPeldanyszam}</th>");            
            }
            tablasorok.Add("</table>");
            File.WriteAllLines("tabla.html",tablasorok);

            //6.feladat
            Console.WriteLine("6.feladat");

            
        }
    }
}
