namespace lez13_api_db.DAL
{
    public interface IDAL<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public bool Insert(T t);
        public bool Update(T t);
        public bool Delete(T t);

    }
}
