using System.Runtime.CompilerServices;

namespace OOP_dolgozat_Keszules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tanulo tanulo = new Tanulo("Kruzsovics Dodika", 19, "12.C");
            Console.WriteLine( tanulo.Tevekenyseg());
            Console.WriteLine( tanulo.Bemutatkozas());


            Tanar tanar = new Tanar("Matek Béla", 59);
            Console.WriteLine ( tanar.Tevekenyseg());
            Console.WriteLine ( tanar.Bemutatkozas());
        }
    }

    abstract class Resztvevo
    {
        private string nev;
        private int eletkor;

        public int Eletkor
        {
            get { return eletkor; }
            set
            {
                eletkor = value;
                if(eletkor < 0 ||  eletkor > 200)
                {
                    throw new ArgumentException("Az életkor a határértéken kívül van");
                }
            }

        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public Resztvevo(string nev, int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }

        public abstract string Tevekenyseg();

        //Gyakorlatilag ugyan úgy fölül írja mint az abstract csak itt meg tudunk adni egy alapot is
        public virtual string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev}, {Eletkor} éves vagyok";
        }
    }

    class Tanulo : Resztvevo
    {
        public Tanulo(string nev, int eletkor, string osztaly) : base(nev, eletkor)
        {
            this.osztaly = osztaly;
        }
        public string osztaly;

        //Konstruktor túlterhelés
        public Tanulo(string nev, int eletkor) : base(nev, eletkor)
        {
            this.osztaly = "Ismeretlen";
        }
        public override string Tevekenyseg() {
            return $"Szia, a nevem {Nev},{Eletkor} éves vagyok. A {osztaly} osztályba járok és teniszezek.";
        }

        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev}, {Eletkor} éves vagyok és a {osztaly} osztályba járok.";
        }
    }

    class Tanar : Resztvevo
    {
        public Tanar(string nev, int eletkor, string szak) : base(nev, eletkor)
        {
            this.szak = szak;
        }

        //Konstruktor túlterhelés
        public Tanar(string nev, int eletkor) : base(nev, eletkor)
        {
            this.szak = "Ismeretlen";
        }

        public string szak;
        public override string Tevekenyseg()
        {
            return $"Szia, a nevem {Nev},{Eletkor} éves vagyok. A {szak} szakot tanítom és éppen kászülök a következő órámra.";
        }
        
        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev}, {Eletkor} éves vagyok és a {szak} szakot tanítom.";
        }
    }
}
