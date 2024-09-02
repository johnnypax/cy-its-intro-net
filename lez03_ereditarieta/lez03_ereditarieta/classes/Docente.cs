using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_ereditarieta.classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }

        public Docente()
        {
            Console.WriteLine("Sono il costruttore di Studente");
        }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"Nome: {Nome}, Cognome: {Cognome}, Codice Fiscale: {CodFis}, Dipartimento: {Dipartimento}");
        }
    }
}
