using lez11_dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez11_dal.DAL
{
    internal class UtenteDAL : IDAL<Utente>
    {
        private static UtenteDAL? istanza;

        public static UtenteDAL getIstanza()
        {
            if (istanza is null)
                istanza = new UtenteDAL();

            return istanza;
        }

        private UtenteDAL() { }
        public bool deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utente> findAll()
        {
            throw new NotImplementedException();
        }

        public Utente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool update(Utente t)
        {
            throw new NotImplementedException();
        }
    }
}
