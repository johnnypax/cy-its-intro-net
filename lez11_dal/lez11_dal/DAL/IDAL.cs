using lez11_dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez11_dal.DAL
{
    internal interface IDAL<T>
    {
        public List<T> findAll();
        public T findById(int id);
        public bool insert(T t);
        public bool update(T t);
        public bool deleteById(int id);
    }
}
