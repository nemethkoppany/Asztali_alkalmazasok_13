using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenyhid_fesztival
{
    internal class Fénykapu
    {
        public string Nev { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Sugar { get; set; }
        public Color Szin { get; set; }

        public Point Pozicio()
        {
            return new Point(X, Y);
        }
    }
}