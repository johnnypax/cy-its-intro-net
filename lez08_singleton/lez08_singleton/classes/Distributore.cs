using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez08_singleton.classes
{
    internal class Distributore
    {
        public List<Prodotto> Lista { get; set; } = new List<Prodotto>();

        private static Distributore? istanza;

        public static Distributore getIstanza()
        {
            if(istanza is null)
                istanza = new Distributore();

            return istanza;
        }

        private Distributore() { }
    }
}
