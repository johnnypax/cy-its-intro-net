using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_astrazione.classes
{
    internal class Gatto : Animale
    {
        public override void VersoEmesso()
        {
            Console.WriteLine("Miau");
        }
    }
}
