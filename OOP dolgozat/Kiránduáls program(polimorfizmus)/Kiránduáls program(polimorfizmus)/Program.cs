namespace Kiránduáls_program_polimorfizmus_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Tanulo tanulo1 = new Tanulo("Anna",17,"11.B");
            Tanulo tanulo2 = new Tanulo("Peti",18,"12.A");
            TanarSegito tanar = new TanarSegito("Béla", 36, "Matek", "felügyel");

            Resztvevo.Felvesz(tanulo1);
            Resztvevo.Felvesz(tanulo2);
            Resztvevo.Felvesz(tanar);

            Resztvevo.Kiiratas();

            
        }

    }

    public class Resztvevo
    {
        private string nev;
        private int eletkor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Eletkor
        {
            get { return eletkor; }
            set { eletkor = value; }
        }

        public Resztvevo(string nev,int eletkor)
        {
            Nev = nev;
            Eletkor = eletkor;
        }

        

        public virtual string Bemutatkozas()
        {
            return $"Szia a nevem {Nev} és {Eletkor} éves vagyok.";
        }

        public virtual string Tevekenyseg()
        {
            return $"{Nev} a gyerekek biztonságát felügyeli";
        }

        private static List<Resztvevo> resztvevok = new List<Resztvevo>();
        public static void Felvesz(Resztvevo resztvevo)
        {
            resztvevok.Add(resztvevo);
        }

        public static void Kiiratas()
        {
            foreach(var resztvevo in resztvevok)
            {
                Console.WriteLine(resztvevo.Bemutatkozas());
                Console.WriteLine(resztvevo.Tevekenyseg());
            }
        }
        
    }

    class Tanulo : Resztvevo
    {
        public string osztaly;
        public Tanulo(string Nev, int Eletkor, string osztaly) : base(Nev,Eletkor)
        {
            this.osztaly = osztaly;
        }

        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev} és {Eletkor} éves vagyok. A(z) {osztaly}-ba/be járok";
        }

        public override string Tevekenyseg() 
        {
            return $"{Nev} teniszezik";
        }
    }

    class Tanar : Resztvevo
    {
        public string szak;
        public Tanar(string Nev, int Eletkor, string szak) : base(Nev, Eletkor)
        {
            this.szak = szak;
        }

        public override string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev} és {Eletkor} éves vagyok. A szakom: {szak}";
        }

        public override string Tevekenyseg()
        {
            return $"{Nev} éppen úszik.";
        }
    }

    class TanarSegito : Tanar
    {
        public string felelosseg;

        public TanarSegito(string Nev, int Eletkor, string szak ,string  felelosseg) : base(Nev,Eletkor,szak)
        {
            this.felelosseg = felelosseg;
        }

        public override string Tevekenyseg()
        {
            return $"{Nev} a következő tevékenységet végzi: {felelosseg}.";
        }
    }
}
