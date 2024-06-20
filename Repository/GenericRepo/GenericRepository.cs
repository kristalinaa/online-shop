using prov.Data;

namespace prov.Repository.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ProvDbContext _context;

        public GenericRepository(ProvDbContext context)
        {
            _context = context;
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async  Task<IEnumerable<TEntity>> GetAll()
        {
            return  _context.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
            }
            _context.SaveChanges();
        }
       

    }
}
