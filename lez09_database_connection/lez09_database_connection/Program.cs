using lez09_database_connection.classes;
using Microsoft.Data.SqlClient;

namespace lez09_database_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "" +
                "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;" +
                "Database=lez01_cy_tabella;" +
                "User Id=academy;" +
                "Password=academy!;" +
                "MultipleActiveResultSets=true;" +
                "Encrypt=false;" +
                "TrustServerCertificate=false";

            #region Lista di tutti i prodotti
            //List<Prodotto> lista = new List<Prodotto>();

            //try
            //{

            //    using(SqlConnection conness = new SqlConnection(credenziali))
            //    {
            //        string query = "SELECT prodottoID, nome, codice, quantita FROM Prodotto";
            //        SqlCommand sqlCommand = new SqlCommand(query, conness);

            //        conness.Open();

            //        SqlDataReader reader = sqlCommand.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Prodotto pro = new Prodotto()
            //            {
            //                Id = reader.GetInt32(0),
            //                Nom = reader.GetString(1),
            //                Cod = reader.GetString(2),
            //                Qua = reader.GetDecimal(3),
            //            };

            //            lista.Add(pro);
            //        }

            //        conness.Close();    
            //    }

            //} catch (Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}

            //foreach (Prodotto pro in lista)
            //{
            //    Console.WriteLine(pro.Nom);
            //}
            #endregion

            #region Inserimento prodotto
            string nomeProd = "Vino";
            string codiceProd = "VIN098";
            decimal quanProd = 9.9M;

            try
            {
                using (SqlConnection conness = new SqlConnection(credenziali))
                {
                    string query = "INSERT INTO Prodotto(nome, codice, quantita) " +
                        "           VALUES (@nom, @cod, @qua);"; 

                    SqlCommand command = new();
                    command.Connection = conness;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@nom", nomeProd);
                    command.Parameters.AddWithValue("@cod", codiceProd);
                    command.Parameters.AddWithValue("@qua", quanProd);

                    conness.Open();

                    int affRows = command.ExecuteNonQuery();
                    if(affRows > 0)
                    {
                        Console.WriteLine("STAPPOOOO");
                    }
                    else
                    {
                        Console.WriteLine("ERRORE");
                    }

                    conness.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
