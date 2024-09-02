using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez01_recap_classi.classes
{
    internal class Persona
    {
		//Implicito
		public string Nome { get; set; } = "";

		//Esplicito
		private string cognome = "";

		public string Cognome
		{
			get { return cognome; }
			set { cognome = value; }
		}

		public string? CodFis { get; set; }

	}
}
