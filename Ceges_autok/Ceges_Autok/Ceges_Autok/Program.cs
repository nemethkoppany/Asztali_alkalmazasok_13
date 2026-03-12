namespace Ceges_Autok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("autok.txt");
            List<Auto> autok = new List<Auto>();
            foreach (string line in lines)
            {
                Auto auto = new Auto(line);
                autok.Add(auto);
            }

            Console.WriteLine("2. feladat");
            Auto utolso = autok.Last(b => b.KiBeHajtas == 0);
            Console.WriteLine($"30. nap rendszám: {utolso.Rendszam}");

            Console.WriteLine("3. feladat");
            Console.Write("Nap: ");
            int bekert = int.Parse(Console.ReadLine());
            List<Auto> elvittVisszahozott = autok.Where(b => b.Nap == bekert).ToList();
            Console.WriteLine($"Forgalom a {bekert}. napon:");
            foreach(Auto auto in elvittVisszahozott)
            {
                string kiBe = (auto.KiBeHajtas == 0) ? "ki" : "be";
                Console.WriteLine($"{auto.Ido} {auto.Rendszam} {auto.SzemelyAzonosito} {kiBe}");
            }

            Console.WriteLine("4. feladat");
            List<string> rendszamok = new List<string>();
            foreach(Auto auto in autok)
            {
                if (!rendszamok.Contains(auto.Rendszam))
                {
                    rendszamok.Add(auto.Rendszam);
                }
                
            }

            foreach(string rendszam in rendszamok)
            {
                Auto elso = autok.First(a=>a.Rendszam == rendszam);
                Auto utso = autok.Last(a=>a.Rendszam==rendszam);
                Console.WriteLine($"{rendszam} {utso.KmSzamlal - elso.KmSzamlal} km");
            }


        }
    }
}
