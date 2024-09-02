using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_ereditarieta.classes
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? CodFis { get; set; }

        public Persona()
        {
            Console.WriteLine("Sono il costruttore di Persona");
        }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"Nome: {Nome}, Cognome: {Cognome}, Codice Fiscale: {CodFis}");
        }
    }
}
