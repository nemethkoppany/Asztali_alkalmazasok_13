using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_dolgozat_gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tanulo tanulo = new Tanulo("Anna", 17);
            Console.WriteLine(tanulo.Tevekenyseg());
            Console.WriteLine(tanulo.Bemutatkozas());

            Tanar tanar = new Tanar("Béla", 34);
            Console.WriteLine(tanar.Tevekenyseg());
            Console.WriteLine(tanar.Bemutatkozas());
        }
    }

    abstract class Resztvevo
    {
        private string Nev;
        private int Eletkor;

        public int eletkor
        {
            get { return Eletkor; }
            set
            {
                Eletkor = value;
                if(Eletkor < 0 ||  Eletkor > 200)
                {
                    throw new ArgumentException();
                }
            }
        }

        public string nev
        {
            get { return Nev; }
            set { Nev = value; }
        }

        public Resztvevo(string Nev, int Eletkor)
        {
            nev = Nev;
            eletkor = Eletkor;
        }

        public abstract string Tevekenyseg();

        public virtual string Bemutatkozas()
        {
            return $"Szia, a nevem {nev} és {eletkor} éves vagyok";
        }
    }

    class Tanulo : Resztvevo
    {
        public string Osztaly;
        public Tanulo(int eletkor, string nev, string Osztaly) : base(nev, eletkor)
        {
            this.Osztaly = Osztaly;
        }

        public Tanulo(string nev, int eletkor) : base(nev, eletkor)
        {
            this.Osztaly = "Ismeretlen";
        }

        public override string Tevekenyseg()
        {
            return $"Szia, a nevem {nev} és {eletkor} éves vagyok és a {Osztaly} osztályba járok. A kedvenc tevékenységem az evezés";
        }

        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {nev} és {eletkor} éves vagyok és a {Osztaly} osztályba járok";
        }
    }

    class Tanar : Resztvevo
    {
        public string Szak;
        public Tanar(string eletkor, int nev, string Szak) : base(eletkor, nev)
        {
            this.Szak = Szak;
        }
        public Tanar(string eletkor, int nev) : base(eletkor, nev)
        {
            this.Szak = "Ismeretlen";
        }

        public override string Tevekenyseg()
        {
            return $"Szia, a nevem {nev} és {eletkor} éves vagyok és a {Szak} szakot tanítom. A kedvenc tevékenységem a focizás";
        }

        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {nev} és {eletkor} éves vagyok és a {Szak} szakot tanítom";
        }
    }
}
