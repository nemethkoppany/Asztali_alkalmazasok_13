using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Console
{
    public class Netflix
    {
        public int Azon { get; set; }
        public string Cím { get; set; }
        public string Rendezo { get; set; }
        public DateTime Hozzadas_datum { get; set; }
        public double Ertekeles {  get; set; }
        public string Nyelv {  get; set; }

        public Netflix(int azon, string cím, string rendezo, DateTime hozzadas_datum, double ertekeles, string nyelv)
        {
            Azon = azon;
            Cím = cím;
            Rendezo = rendezo;
            Hozzadas_datum = hozzadas_datum;
            Ertekeles = ertekeles;
            Nyelv = nyelv;
        }

    }
    
}
