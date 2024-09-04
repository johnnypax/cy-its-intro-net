using lez08_singleton.classes;

namespace lez08_singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Distributore distUno = Distributore.getIstanza();
            Distributore distDue = Distributore.getIstanza();
            Distributore distTre = Distributore.getIstanza();
            Distributore distQua = Distributore.getIstanza();
        }
    }
}
