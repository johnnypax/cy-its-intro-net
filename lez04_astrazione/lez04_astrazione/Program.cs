using lez04_astrazione.classes;

namespace lez04_astrazione
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Animale ani = new Animale();

            Gatto ga = new Gatto();
            Cane ca = new Cane();

            List<Animale> elenco = new List<Animale>();
            elenco.Add(ga);
            elenco.Add(ca);

            List<Object> lista = new List<Object>();
            elenco.Add(ga);
            elenco.Add(ca);

        }
    }
}
