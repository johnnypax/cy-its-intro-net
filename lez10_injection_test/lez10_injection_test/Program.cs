using lez10_injection_test.classes;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace lez10_injection_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=lez01_cy_tabella;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            #region Ricerca di un utente

            Console.WriteLine("Inserisci lo username");
            string? user = Console.ReadLine();
            Console.WriteLine("Inserisci la password");
            string? pass = Console.ReadLine();

            //string user = "' OR 1 = 1 --";
            //string pass = "giuerhgeoier";

            List<Utente> list = new List<Utente>();

            try
            {
                using(SqlConnection connection = new SqlConnection(credenziali))
                {
                    //SELECT * FROM Utenti WHERE usern = '' OR 1 = 1 --AND passw = 'giuerhgeoier''
                    string query = $"SELECT * FROM Utenti WHERE usern = '{user}' AND passw = '{pass}'";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Utente ute = new Utente()
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Ruolo = reader.GetString(3),
                        };

                        list.Add(ute);
                    }

                    connection.Close();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (Utente ut in list)
            {
                Console.WriteLine(ut);
            }

            #endregion

        }
    }
}
