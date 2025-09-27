namespace Orai_anyag_2025_09_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hallgato hallgato = new Hallgato();
            hallgato.Atlag = 3;
            Kurzus hallgato2 = new Kurzus();
            hallgato.Nev = "Borsos Imre";
            hallgato2.Felvesz(hallgato);
            hallgato2.Listaz();
        }
    }

 
class Hallgato
    {
        public string Nev { get; set; }
        private double atlag;
        public double Atlag
        {
            get { return atlag; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException();

                }
                else atlag = value;
            }
        }


    }
    class Kurzus
    {
        public List<Hallgato> Hallgatok { get; set; } = new List<Hallgato>();
        public void Felvesz(Hallgato h)
        {
            Hallgatok.Add(h);
        }

        public void Listaz()
        {
            foreach (var h in Hallgatok)
            {
                Console.WriteLine($"A hallgato neve: {h.Nev} és az átlaga {h.Atlag}");
            }
        }
    }
}
