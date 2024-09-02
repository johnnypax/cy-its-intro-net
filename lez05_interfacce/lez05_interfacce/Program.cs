using lez05_interfacce.classes;

namespace lez05_interfacce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale can = new Cane();
            Animale gat = new Gatto();

            List<Animale> animals = new List<Animale>();   
            animals.Add(can);
            animals.Add(gat);
        }
    }
}
