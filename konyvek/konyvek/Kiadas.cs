using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    public class Kiadas
    {
        public int Evszam { get; set; }
        public int Negyedev {  get; set; }
        public string Eredet { get; set; }
        public string Leiras {  get; set; }
        public int Peldanyszam {  get; set; }

        public Kiadas(string sor)
        {
            string[] sorDarabok = sor.Split(';');
            Evszam = int.Parse(sorDarabok[0]);
            Negyedev = int.Parse(sorDarabok[1]);
            Eredet = sorDarabok[2];
            Leiras = sorDarabok[3];
            Peldanyszam = int.Parse(sorDarabok[4]);
        }
    }
}
