using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_interfacce.classes
{
    internal class Gatto : Animale
    {
        public string? Colore { get; set; }
        public bool HasPelo { get; set; }

        public void ModoDiMovimento()
        {
            Console.WriteLine("Cammina");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("Miau");
        }
    }
}
