using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok
{
    internal class Autok
    {
        public string Rendszam { get; set; }
        public int Ora {  get; set; }
        public int Perc {get; set; }
        public int Sebesseg { get; set; }

        public Autok(string line)
        {
            string[] lineParts = line.Split("\t");
            Rendszam = lineParts[0];
            Ora = int.Parse( lineParts[1]);
            Perc = int.Parse( lineParts[2]);
            Sebesseg = int.Parse( lineParts[3]);

        }
    }
}
