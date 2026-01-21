using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix_Nemeth_Koppany
{
    public class Netflix
    {
        public int Azon { get; set; }
        public string Cím { get; set; }
        public string Rendezo { get; set; }
        public DateTime Hozzaadas_datuma {  get; set; }
        public double Ertekeles {  get; set; }
        public string Nyelv {  get; set; }

        public Netflix(int azon, string cím, string rendezo, DateTime hozzaadas_datuma, double ertekeles, string nyelv)
        {
            Azon = azon;
            Cím = cím;
            Rendezo = rendezo;
            Hozzaadas_datuma = hozzaadas_datuma;
            Ertekeles = ertekeles;
            Nyelv = nyelv;
        }
    }

         
   }
