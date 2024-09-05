using lez11_dal.DAL;
using lez11_dal.Models;

namespace lez11_dal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool insAbilitato = true;

            while (insAbilitato)
            {
                Console.WriteLine("Digita I per l'inserimento, S per la stampa e Q per quit");
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":
                        Console.WriteLine("Inserisci il nome del prodotto");
                        string? nomeProd = Console.ReadLine();
                        Console.WriteLine("Inserisci il codice del prodotto");
                        string? codiProd = Console.ReadLine();
                        Console.WriteLine("Inserisci la quantità del prodotto");
                        string? quanProdString = Console.ReadLine();

                        decimal quantitaProd = 0M;
                        try
                        {
                            quantitaProd = Convert.ToDecimal(quanProdString);
                        }
                        catch
                        {
                            Console.WriteLine("ERRORE DI CONVERSIONE, IMPOSTO 0");
                        }

                        Prodotto pro = new Prodotto()
                        {
                            Nom = nomeProd,
                            Cod = codiProd,
                            Qua = quantitaProd
                        };

                        if (ProdottoDAL.getIstanza().insert(pro))
                            Console.WriteLine("STAPPOOOO");
                        else
                            Console.WriteLine("Elemento non inserito");

                        break;
                    case "S":
                        break;
                    case "Q":
                        insAbilitato = false;
                        break;
                }


            }
           
        }
    }
}
