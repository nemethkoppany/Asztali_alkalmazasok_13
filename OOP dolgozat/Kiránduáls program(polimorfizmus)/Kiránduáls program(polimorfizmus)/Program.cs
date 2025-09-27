namespace Kiránduáls_program_polimorfizmus_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Szükség lesz még példányosításra
            //Külön osztályokba kell ezt rendezni mert rosszult értelmeztem a feladatot
            //Technikailag már megvan minden a szorgalmit leszámítva de majd úgy is át kell írni a dolgokat
            //TanarSegito osztály még szükséges
            //Pontosan mi is az a polimorfizmus?
        }

        List<Program>Resztvevok = new List<Program>();

        private string nev;
        private int eletkor;
        private string osztaly;
        private string szak;

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

        public string Osztaly
        {
            get { return osztaly; }
            set { osztaly = value; }
        }

        public string Szak
        {
            get { return szak; }
            set { szak = value; }
        }

        public Program(int eletkor, string nev)
        {
            Eletkor = eletkor;
            Nev = nev;
        }

        public string Bemutatkozas()
        {
            return $"Szia, a nevem {Nev}, {Eletkor} éves vagyok. A {Osztaly}ba/be járok.";
        }

        public virtual string Tevekenyseg()
        {
            return $"{Nev} éppen egy tevékenységet végez";
        }
        
        public void Felvesz(Program tanulo)
        {
            Resztvevok.Add(tanulo);
        }

        public void Listaz()
        {
            foreach (Program t in Resztvevok)
            {
                t.Bemutatkozas();
                t.Tevekenyseg();
            }
        }
    }
}
