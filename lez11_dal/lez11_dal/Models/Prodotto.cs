using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez11_dal.Models
{
    internal class Prodotto
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Cod { get; set; }
        public decimal Qua { get; set; }

        public override string ToString()
        {
            return $"{Id} {Nom} {Cod} {Qua}";
        }
    }
}
