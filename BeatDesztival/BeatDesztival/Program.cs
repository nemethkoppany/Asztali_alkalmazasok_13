namespace BeatDesztival
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("fellepesek.csv");
            List<Fesztival> beatfesztival = new List<Fesztival>();
            foreach (string line in lines.Skip(1))
            {
                string[] lineparts = line.Split(";");
                Fesztival fesztival = new Fesztival(
                    azon: int.Parse(lineparts[0]),
                    eloado: lineparts[1],
                    szinpad: lineparts[2],
                    datum: DateOnly.Parse(lineparts[3]),
                    kezdes: lineparts[4],
                    pontszam: float.Parse(lineparts[5]),
                    mufaj: lineparts[6],
                    orszagkod: lineparts[7]
                    );
                beatfesztival.Add( fesztival );
            };

            Console.WriteLine("3. feladat");
            var utolso = beatfesztival.Last();
            Console.WriteLine($"Az utolsó fellépés:{utolso.Eloado} - {utolso.Datum} {utolso.Kezdes}");

            Console.WriteLine("4. feladat");
            Dictionary<string, int> fellepesek = new Dictionary<string, int>();

            foreach(var beat in beatfesztival)
            {
                if (fellepesek.ContainsKey(beat.Szinpad))
                {
                    fellepesek[beat.Szinpad]++;
                }
                else
                {
                    fellepesek[beat.Szinpad] = 1;
                }
            }

            foreach(var fellepes in fellepesek.OrderBy(kv => kv.Key))
            {
                Console.WriteLine($"{fellepes.Key}:{fellepes.Value} db");
            }

            Console.WriteLine("5. feladat");
            var magyarAtlag = beatfesztival.Where(o => o.Orszagkod == "HU").Average(k => k.Pontszam);
            Console.WriteLine($"A magyar fellépők átlagos pontszáma: {magyarAtlag:0.00}");

            Console.WriteLine("6. feladat");
            Console.Write("Kérek egy előadónevet: ");
            var eloado = Console.ReadLine();

            List<string> list = new List<string>();
            list.Add("azon;eloado;szinpad;datum;kezdes;pontszam;mufaj;orszagkod");
            foreach(var e in beatfesztival)
            {
                if (e.Eloado.ToLower() == eloado.ToLower())
                {
                    list.Add($"{e.Azon};{e.Eloado};{e.Szinpad};{e.Datum};{e.Kezdes};{e.Pontszam};{e.Mufaj};{e.Orszagkod}");
                }
            }
            if(list.Count == 1)
            {
                Console.WriteLine("A megadott előadóhoz nem tartozik egyetlen fellépés sem!");
            }
            File.WriteAllLines("eloado.csv",list);

        }
    }
}
