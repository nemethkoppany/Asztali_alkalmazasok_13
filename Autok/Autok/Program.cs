namespace Autok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("jeladas.txt");
            List<Autok> autok = new List<Autok>();
            foreach (string line in lines)
            {
                Autok auto = new Autok(line);
                autok.Add(auto);
            }


            Console.WriteLine("2. feladat");

            var utolso = autok.OrderByDescending(a => a.Ora)
                .ThenByDescending(a => a.Perc)
                .First();
            Console.WriteLine($"Az utolsó jeladás időpontja {utolso.Ora}:{utolso.Perc}, a jármű rendszáma {utolso.Rendszam}");


            Console.WriteLine("3. feladat");

            var elsoRendszam = autok.First().Rendszam;

            var idopontok = autok.Where(a => a.Rendszam == elsoRendszam)
                .Select(a => $"{a.Ora}:{a.Perc} ");

            Console.WriteLine($"Az első jármű: {elsoRendszam}");
            Console.Write("Jeladásainak időpontja: ");
            foreach(var ido in idopontok)
            {
                Console.Write(ido);
            }
            
        }
    }
}
