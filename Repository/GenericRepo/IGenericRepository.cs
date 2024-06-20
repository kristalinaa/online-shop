namespace prov.Repository.GenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
