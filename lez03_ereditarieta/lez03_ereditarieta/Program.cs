using lez03_ereditarieta.classes;

namespace lez03_ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Studente stu = new()
            //{
            //    Matricola = "AB12345",
            //    Nome = "Gio",
            //    Cognome = "Pace",
            //    CodFis = "PCAGNN"
            //};

            //stu.StampaDettaglio();

            Studente stuUno = new Studente()
            {
                Matricola = "AB12345",
                Nome = "Gio",
                Cognome = "Pace",
                CodFis = "PCAGNN"
            };
            Studente stuDue = new Studente()
            {
                Matricola = "AB12346",
                Nome = "Val",
                Cognome = "Ver",
                CodFis = "VLRVRD"
            };

            Docente dUno = new Docente()
            {
                Dipartimento = "Informatica",
                Nome = "Mar",
                Cognome = "Ros",
                CodFis = "MRRRSS"
            };

            Persona perUno = new Persona()
            {

            };

            List<Persona> elenco = new List<Persona>();
            elenco.Add(stuUno);
            elenco.Add(stuDue);
            elenco.Add(dUno);
            elenco.Add(perUno);

        }
    }
}
