using lez13_api_db.Models;
using Microsoft.Data.SqlClient;

namespace lez13_api_db.DAL
{
    public class ProdottoDAL : IDAL<Prodotto>
    {
        private static ProdottoDAL? instance;

        public static ProdottoDAL getInstance()
        {
            if (instance == null)
                instance = new ProdottoDAL();

            return instance;
        }

        private ProdottoDAL() { }

        public bool Delete(Prodotto t)
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> GetAll()
        {
            List<Prodotto> lista = new List<Prodotto>();

            try
            {

                using (SqlConnection conness = new SqlConnection(Config.credenziali))
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
                            Nome = reader.GetString(1),
                            Codi = reader.GetString(2),
                            Quan = reader.GetDecimal(3),
                        };

                        lista.Add(pro);
                    }

                    conness.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public Prodotto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Prodotto t)
        {
            try
            {
                using (SqlConnection conness = new SqlConnection(Config.credenziali))
                {
                    string query = "INSERT INTO Prodotto(nome, codice, quantita) " +
                        "           VALUES (@nom, @cod, @qua);";

                    SqlCommand command = new();
                    command.Connection = conness;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@nom", t.Nome);
                    command.Parameters.AddWithValue("@cod", t.Codi);
                    command.Parameters.AddWithValue("@qua", t.Quan);

                    conness.Open();

                    int affRows = command.ExecuteNonQuery();

                    conness.Close();

                    if (affRows > 0)
                        return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Update(Prodotto t)
        {
            throw new NotImplementedException();
        }
    }
}
