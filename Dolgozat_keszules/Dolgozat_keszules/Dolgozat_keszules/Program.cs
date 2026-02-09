namespace Dolgozat_keszules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    abstract class Resztvevo
    {
        private string nev;
        private int eletkor;

        public Resztvevo(string nev, int eletkor)
        {
            this.nev = nev;
            this.eletkor = eletkor;
        }

        public int Eletkor
        {
            get { return eletkor;}

            set
            {
                if(value  < 0 || value > 200)
                {
                    throw new ArgumentException();
                }
                else
                {
                    eletkor = value;
                }
            }
        }

        public int Eletkor1 { get => eletkor; set => eletkor = value; }
        public string Nev { get => nev; set => nev = value; }

        public abstract string Tevekenyseg();

        public virtual string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev}, {Eletkor} éves vagyok.";
        }

    }

    class Tanulo : Resztvevo
    {
        public Tanulo(string nev, int eletkor, string osztaly) : base(nev, eletkor)
        {
            this.osztaly = osztaly;
        }

        private string osztaly;

        public override string Tevekenyseg()
        {
            return $"Szia, a nevem {Nev},{Eletkor} éves vagyok. A {osztaly} osztályba járok. {Nev} teniszezik.";
        }
    }

    class Tanar : Resztvevo
    {
        public Tanar(string nev, int eletkor, string szak) : base(nev, eletkor)
        {
            this.szak = szak;
        }

        private string szak;

        public override string Tevekenyseg()
        {
            return $"Szia, a nevem {Nev},{Eletkor} éves vagyok. A szakom: {szak}. {Nev} tanít.";
        }
    }
}
