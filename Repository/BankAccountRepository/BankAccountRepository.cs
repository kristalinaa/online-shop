using prov.Data;
using prov.Models;
using prov.Repository.GenericRepo;

namespace prov.Repository.BankAccountRepository
{
    public class BankAccountRepository : GenericRepository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(ProvDbContext context) : base(context)
        {
        }
    }
}
