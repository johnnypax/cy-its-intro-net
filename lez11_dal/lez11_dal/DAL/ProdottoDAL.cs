using lez11_dal.Models;
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
            throw new NotImplementedException();
        }

        public bool update(Prodotto t)
        {
            throw new NotImplementedException();
        }
    }
}
