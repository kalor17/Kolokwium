using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Pizza
    {
        private string nazwa;
        private decimal suma = 15;
        private List<Skladnik> skladniki = new List<Skladnik>();
        private string sos;

        public void DodajSkladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            skladniki.Add(new Skladnik(nazwaSkladnika, cenaSkladnika));
            suma = +(decimal)cenaSkladnika;
        }

        public void DodajSos(string sos)
        {
            this.sos = sos;
        }

        public void UstawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public override string ToString()
        {
            skladniki.Sort();
            if (skladniki.Count == 0)
            {
                return "";
            }
            string opis = "Pizza: "+nazwa+Environment.NewLine;
            foreach (var element in skladniki)
            {
                opis += element.ToString() + Environment.NewLine;
            }
            opis += "Sos: " + sos + Environment.NewLine;
            opis += "Suma: " + suma;
            return opis;
        }

        public bool CzyNazwa()
        {
            if (this.nazwa == null) return false;
            return true;
        }

        public bool CzyPizza()
        {
            if (skladniki.Count > 1 && this.sos != null) return true;
            return false;
        }
        
        
    }
}
