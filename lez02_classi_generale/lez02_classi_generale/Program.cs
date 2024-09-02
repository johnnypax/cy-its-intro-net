using lez02_classi_generale.classes;

namespace lez02_classi_generale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per = new()
            {
                Nome = "Giovanni",
                Cognome = "Pace",
                CodFis = "PCAGNN"
            };

            Persona perDue = new()
            {
                Nome = "Valeria",
                Cognome = "Verdi"
            };

            Console.WriteLine(per);
            Console.WriteLine(perDue);
        }
    }
}
