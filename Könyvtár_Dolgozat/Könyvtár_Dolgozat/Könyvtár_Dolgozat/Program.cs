using System.Runtime.InteropServices;

namespace Könyvtár_Dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyvtar konyvtar = new Konyvtar();
            Szakkonyv szakkonyv = new Szakkonyv("asd",3850);
            Regeny regeny = new Regeny("uoiafg",12000);
            Console.WriteLine(szakkonyv.Kolcsonzes());
            konyvtar.Hozzaad(szakkonyv);
            konyvtar.Hozzaad(regeny);

            konyvtar.Kiiras();

            
            
        }
    }

    abstract class Konyvek
    {
        private string Cim;
        private decimal Ar;

        public string cim
        {
            get { return Cim; }
        }

        public decimal ar
        {
            get { return Ar; }
            set { 
                if(value < 0)
                {
                    throw new ArgumentException("Az Ár nem megfelelő");
                }
                else
                {
                    ar = value;
                }
            }
        }

        public Konyvek(string cim, decimal ar)
        {
            Cim = cim;
            Ar = ar;
        }

        public abstract string Leiras();
        public virtual string Kolcsonzes()
        {
            return $"A könyv kikölcsönözhető";
        }

    }

    class Szakkonyv : Konyvek
    {
        public Szakkonyv(string cim, decimal ar) : base(cim, ar)
        {

        }

        public override string Leiras()
        {
            return $"Szakkönyv: {cim} - {ar} Ft";
        }

        public override string Kolcsonzes()
        {
            return $"A könyv csak helyben olvasható";
        }
    }

    class Regeny : Konyvek
    {
        public Regeny(string cim, decimal ar) : base(cim, ar)
        {

        }
        public override string Leiras()
        {
            return $"Regény: {cim} - {ar} Ft";
        }
    }

    class Konyvtar
    {

        List<Konyvek>Konyvek = new List<Konyvek>();

        public void Hozzaad(Konyvek konyv)
        {
            Konyvek.Add(konyv);
        }

        public void Kiiras()
        {
            foreach(var konyv in Konyvek)
            {
                Console.WriteLine(konyv.Leiras());
            }
        }
    }
}
