using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class NaWynos : Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (base.czasDostawy > DateTime.Now.AddHours(3)) return true;
            return false;
        }
    }
}
