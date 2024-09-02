using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez01_recap_classi.classes
{
    internal class Automobile
    {
        public string? Marca { get; set; } = "";
        public string? Colore { get; set; }
        public int Cilindrata { get; set; } = 0;
        public string Matricola { get; set; } = null!;

        private int numPorte;

        public int NumPorte
        {
            get {
                if (numPorte == 0)
                    Console.WriteLine("ERRORE, porte non settate");

                return numPorte;
            }
            set {
                if (value > 0)
                    numPorte = value;
                else
                    Console.WriteLine("ERRORE INPUT");
            }
        }

    }
}
