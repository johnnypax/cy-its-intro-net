using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_ereditarieta.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente() {
            Console.WriteLine("Sono il costruttore di Studente");
        }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"Nome: {Nome}, Cognome: {Cognome}, Codice Fiscale: {CodFis}, Matricola: {Matricola}");
        }
    }
}
