using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatDesztival
{
    internal class Fesztival
    {
        public int Azon {  get; set; }
        public string Eloado { get; set; }
        public string Szinpad { get; set; }
        public DateOnly Datum {  get; set; }
        public string Kezdes { get; set; }
        public float Pontszam {  get; set; }
        public string Mufaj { get; set; }
        public string Orszagkod { get; set; }
        
        public Fesztival(int azon, string eloado, string szinpad, DateOnly datum, string kezdes, float pontszam, string mufaj, string orszagkod)
        {
            Azon = azon;
            Eloado = eloado;
            Szinpad = szinpad;
            Datum = datum;
            Kezdes = kezdes;
            Pontszam = pontszam;
            Mufaj = mufaj;
            Orszagkod = orszagkod;
        }
    }
}
