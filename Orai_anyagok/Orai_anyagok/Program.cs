using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Orai_anyagok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jarmu jarmu = new Jarmu();
            //Auto auto = new Auto();
            //Bicikli bicikli = new Bicikli();


            //auto.Uzemanyag = 30;

            //jarmu.Halad();
            //auto.Tankol();
            //bicikli.Csenget();

            //bicikli.Sebesseg = 20;
            //(bicikli as Jarmu).Halad();

            //Kor kor = new Kor();
            //Negyzet negyzet = new Negyzet();
            //Haromszog haromszog = new Haromszog();

            //kor.sugar = 2;
            //negyzet.Oldal = 2;
            //haromszog.Oldal = 3;
            //haromszog.Magassag = 3;

            //Console.WriteLine( $"A kör területe {kor.Terulet()}");
            //Console.WriteLine($"A négyzet területe {negyzet.Terulet()}"); ;
            //Console.WriteLine($"A háromszög területe {haromszog.Terulet()}");


            //IJarmu auto = new Auto();
            //auto.Indit();
            //auto.Megall();

            //IJarmu bicikli = new Bicikli();
            //bicikli.Indit();
            //bicikli.Megall();

            //List<IJarmu> jarmuvek = new List<IJarmu>();
            //    jarmuvek.Add(auto);
            //    jarmuvek.Add(bicikli);

            //foreach(var jarmu in jarmuvek)
            //{
            //    jarmu.Indit();
            //    jarmu.Megall();
            //}


            aőfghpohisfdghéojnlsfdghjk teglalap = new aőfghpohisfdghéojnlsfdghjk();
            Console.WriteLine($"A téglalap területe: {teglalap.Terulet(2, 5)}");
        }

    }
    //class Jarmuy
    //{
    //    public int Sebesseg { get; set; } = 40;
    //    public void Halad() => Console.WriteLine($"A Jármű {Sebesseg}-el(-al) halad");
    //}

    //class Auto : Jarmu
    //{
    //    public int Uzemanyag {  get; set; }
    //    public void Tankol() => Console.WriteLine($"A Jármű {Uzemanyag} litert tankol");
    //}

    //class Bicikli : Jarmu
    //{
    //    public void Csenget()
    //    {
    //        Console.WriteLine($"A bicikli csenget");
    //    }
    //}

    //abstract class Alakzat
    //{
    //    public abstract double Terulet();
    //}

    //class Kor : Alakzat {
    //    public double sugar { get; set; }
    //    public override double Terulet() {
    //        return sugar * sugar * 3.14;
    //    }
    //}

    //class Negyzet : Alakzat
    //{
    //    public double Oldal { get; set; }

    //    public override double Terulet()
    //    {
    //        return Oldal * Oldal;
    //    }
    //}

    //class Haromszog : Alakzat
    //{
    //    public double Oldal { get; set; }
    //    public double Magassag { get; set; }

    //    public override double Terulet()
    //    {
    //        return (Oldal * Magassag) / 2;
    //    }
    //}

    //interface IJarmu
    //{
    //    public void Indit();
    //    public void Megall();


    //}

    //class Auto : IJarmu
    //{
    //    public void Indit()
    //    {
    //        Console.WriteLine("Az autó motorja beindult.");
    //    }

    //    public void Megall()
    //    {
    //        Console.WriteLine("Az autó megállt.");
    //    }

    //}

    //class Bicikli : IJarmu
    //{
    //    public void Indit()
    //    {
    //        Console.WriteLine("A bicikli gurulni kezd.");
    //    }
    //    public void Megall()
    //    {
    //        Console.WriteLine("A bicikli megállt.");
    //    }
    //}


    class Teglalap
    {
        public int Szelesseg { get; set; }
        public int Magassag { get; set; }


        public Teglalap(int a, int b)
        {
            a = Szelesseg;
            b = Magassag;
        }

        public Teglalap(int a)
        {
            a = Szelesseg;
        }



    }

    class aőfghpohisfdghéojnlsfdghjk
    {
        public int Kerulet(int a, int b)
        {
            return 2 * (a + b);
        }

        public int Kerulet_negyzet(int oldal)
        {
            return oldal * oldal;
        }

        public int Terulet(int a, int b)
        {
            return a * b;
        }
    }




}