using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Datum_Validacio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. feladat
            var culture = CultureInfo.InvariantCulture; DateTime dt; while (true)
            {
                Console.Write("Dátum (yyyy-MM-dd): ");
                var s = Console.ReadLine();
                if (DateTime.TryParseExact(s, "yyyy-MM-dd", culture, DateTimeStyles.None, out dt))
                    break;

                Console.WriteLine("Hibás formátum, próbáld újra!");
            }
            Console.WriteLine($"Érvényes dátum: {dt:yyyy-MM-dd} ({dt:dddd})");


            //2. feladat
            Console.Write("Adj meg egy évet: ");
            int ev = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(ev))
            {
                Console.WriteLine("Ez egy szökőév");
            }
            else
            {
                Console.WriteLine("Ez nem egy szökőév");
            }

            //3. feladat
            Console.Write("Írj be két dátumot (az első legyen kisebb mint a második): ");
            DateTime kezdo = DateTime.Parse(Console.ReadLine());
            DateTime vege = DateTime.Parse(Console.ReadLine());
            int nap = (int)(vege - kezdo).TotalDays;
            int het = nap / 7;
            int honap = (vege.Year - kezdo.Year) * 12 + (vege.Month - kezdo.Month);

            Console.WriteLine($"{nap} nap, {het} hét, {honap} hónap telt el a két dátum között");

            //4. feladat
            Console.Write("Adj meg egy dátumot: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());


            DateTime kovetkezoMunkanap;
            if (datum.DayOfWeek == DayOfWeek.Friday)
            {
                kovetkezoMunkanap = datum.AddDays(3);
            }
            else if (datum.DayOfWeek == DayOfWeek.Saturday)
            {
                kovetkezoMunkanap = datum.AddDays(2);
            }
            else if (datum.DayOfWeek == DayOfWeek.Sunday)
            {
                kovetkezoMunkanap = datum.AddDays(1);
            }
            else
            {
                kovetkezoMunkanap = datum.AddDays(1);
            }
            Console.WriteLine(kovetkezoMunkanap.ToString("yyy-MM-dd"));


            //5. feladat

            Console.WriteLine("Adj meg egy dátumot");
            DateTime beolvasott = DateTime.Parse(Console.ReadLine());
            DateTime evVege = new DateTime(beolvasott.Year, 12, 31);

            int nap = (evVege - beolvasott).Days;

            Console.WriteLine($"Már csak {nap} nap van hátra az évből");

            //6.feladat

            Console.WriteLine("Mikor születtél? ");
            DateTime szuletesnap = DateTime.Parse(Console.ReadLine());
            DateOnly maiDatum = DateOnly.FromDateTime(DateTime.Now);
            int evkulombseg = maiDatum.Year - szuletesnap.Year;
            if (szuletesnap.AddYears(evkulombseg) > )
            {

            }


        }
    }
}
