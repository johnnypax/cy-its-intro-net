using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez02_classi_generale.classes
{
    internal class Persona : Object
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? CodFis { get; set; }

        public Persona()
        {
            Console.WriteLine("Costruttore Default");
        }

        public override string ToString()
        {
            return $"" +
                $"Nome: {Nome}, " +
                $"Cognome: {Cognome}, " +
                $"Cofice fiscale: {CodFis}";
        }
    }
}
