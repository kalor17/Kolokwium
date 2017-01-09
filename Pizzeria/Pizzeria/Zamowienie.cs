using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;

        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy > DateTime.Now) return true;
            return false;
        }

        public void UstawCzasDostawy(DateTime czas)
        {
            this.czasDostawy = czas;
        }
    }
}
