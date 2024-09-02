using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_astrazione.classes
{
    internal abstract class Animale
    {
        public bool HasPelo { get; set; }
        public int NumZampe { get; set; }
        public bool Vola { get; set; }

        public abstract void VersoEmesso();
    }
}
