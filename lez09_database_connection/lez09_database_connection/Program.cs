using lez09_database_connection.classes;
using Microsoft.Data.SqlClient;

namespace lez09_database_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=lez01_cy_tabella;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            List<Prodotto> lista = new List<Prodotto>();

            try
            {

                using(SqlConnection conness = new SqlConnection(credenziali))
                {
                    string query = "SELECT prodottoID, nome, codice, quantita FROM Prodotto";
                    SqlCommand sqlCommand = new SqlCommand(query, conness);

                    conness.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Prodotto pro = new Prodotto()
                        {
                            Id = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Cod = reader.GetString(2),
                            Qua = reader.GetDecimal(3),
                        };

                        lista.Add(pro);
                    }

                    conness.Close();    
                }

            } catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }

            foreach (Prodotto pro in lista)
            {
                Console.WriteLine(pro.Nom);
            }
        }
    }
}
