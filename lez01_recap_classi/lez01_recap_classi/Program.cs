using lez01_recap_classi.classes;

namespace lez01_recap_classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona per = new Persona();
            //per.Nome = "Giovanni";
            //per.Cognome = "Pace";
            //per.CodFis = "PCAGNN";

            //Console.WriteLine(per.Nome);

            Automobile auto = new();
            //auto.Matricola = "AB12345";
            auto.NumPorte = 5;
            Console.WriteLine(auto.NumPorte);
        }
    }
}
