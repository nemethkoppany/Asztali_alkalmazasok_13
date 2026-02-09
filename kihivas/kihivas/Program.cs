namespace kihivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("1.feladat");
            Console.WriteLine("Adja meg az aktivitását: ");
            string bekert_adat = Console.ReadLine();
            string bekertAdatUpper = bekert_adat.ToUpper();

            //2. feladat
            Console.WriteLine("2. feladat");

            int U = 0;
            int G = 0;
            int F = 0;
            int K = 0;

            foreach(char adat in bekertAdatUpper)
            {
                if(adat == 'U')
                {
                    U++;
                }
                else if(adat == 'G')
                {
                    G++;
                }
                else if (adat == 'F')
                {
                    F++;
                }
                else if (adat == 'F')
                {
                    F++;
                }
                else if (adat == 'K')
                {
                    K++;
                }
            }
            int osszes = U + G + (F * 2) + (K * 10);
            Console.WriteLine($"Az elért távolság: {osszes} km.");

            //3. feladat
            Console.WriteLine("3. feladat");
            string eredmeny = Jutalom(bekert_adat);
            Console.WriteLine(eredmeny);

            //4. feladat
            Console.WriteLine("4. feladat");
            if())
            {

            }
        }

        public static string Jutalom(string adat)
        {
            if(adat.ToString().Contains("U") && adat.ToString().Contains("G") && adat.ToString().Contains("F") && adat.ToString().Contains("K"))
            {
                return "Bravó! Jutalma még 10 km";
            }
            else
            {
                return "Nem jár jutalom";
            }
        }

        public static int Teljes(int bekert_adat, int jutalom_adat)
        {
            if (jutalom_adat.ToString().Contains("Barvó"))
            {
                return bekert_adat + 10;
            }
            else
            {
                return bekert_adat;
            }


        }
    }
}
