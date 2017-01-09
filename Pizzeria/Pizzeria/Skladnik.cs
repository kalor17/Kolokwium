using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Skladnik : IComparable
    {
        private string nazwaSkladnika;
        private double cenaSkladnika;

        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }

        public override string ToString()
        {
            return "Nazwa: " + nazwaSkladnika + ", cena: " + cenaSkladnika;
        }

        public double ReturnCena()
        {
            return this.cenaSkladnika;
        }

        public int CompareTo(Object obj)
        {
            Skladnik skladnik = obj as Skladnik;
            return this.nazwaSkladnika.CompareTo(skladnik.nazwaSkladnika);
        }
    }
}
