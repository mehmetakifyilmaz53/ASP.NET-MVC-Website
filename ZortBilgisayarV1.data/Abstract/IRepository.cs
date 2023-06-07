namespace ZortBilgisayarV1.data.Abstract
{
    public interface IRepository<T>
    {
        List<T> Getall();
        public T GetById(int id);
        public void Create (T entity);
        public void Update (T entity);
        public void Delete (T entity);
    }
}