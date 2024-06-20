using prov.Data;
using prov.Models;
using prov.Repository.GenericRepo;

namespace prov.Repository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ProvDbContext context) : base(context)
        {
        }

        // Add specific methods for User entity if needed
    }
}
