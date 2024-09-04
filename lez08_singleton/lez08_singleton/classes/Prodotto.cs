using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez08_singleton.classes
{
    internal abstract class Prodotto
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public string? Codice { get; set; }
        public double Prezzo { get; set; } = 0;
    }
}
