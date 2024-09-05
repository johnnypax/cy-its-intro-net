using lez11_dal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez11_dal.DAL
{
    internal class ProdottoDAL : IDAL<Prodotto>
    {
        private static ProdottoDAL? istanza;

        public static ProdottoDAL getIstanza()
        {
            if(istanza is null)
                istanza = new ProdottoDAL();

            return istanza;
        }

        private ProdottoDAL() { }

        public bool deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> findAll()
        {
            throw new NotImplementedException();
        }

        public Prodotto findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Prodotto t)
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
                    command.Parameters.AddWithValue("@nom", t.Nom);
                    command.Parameters.AddWithValue("@cod", t.Cod);
                    command.Parameters.AddWithValue("@qua", t.Qua);

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

        public bool update(Prodotto t)
        {
            throw new NotImplementedException();
        }
    }
}
