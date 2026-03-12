using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceges_Autok
{
    internal class Auto
    {
        public int Nap { get; set; }
        public string Ido {  get; set; }
        public string SzemelyAzonosito { get; set; }
        public string Rendszam { get; set; }
        public int KmSzamlal { get; set; }
        public int KiBeHajtas {  get; set; }

        public Auto(string line)
        {
            string[] lineParts = line.Split(" ");
            Nap = int.Parse(lineParts[0]);
            Ido = lineParts[1];
            Rendszam = lineParts[2];
            SzemelyAzonosito = lineParts[3];
            KmSzamlal = int.Parse(lineParts[4]);
            KiBeHajtas = int.Parse(lineParts[5]);
        }
    }
}
