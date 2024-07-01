using prov.Data;
using prov.Models;
using prov.Repository.BankAccountRepository;
using prov.Repository.UserRepository;
using prov.services.BankAccountS;
using System.Security.Principal;

namespace prov.services.BankAccountS
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly ProvDbContext _context;

        public BankAccountService(IBankAccountRepository bankAccountRepository, ProvDbContext context)
        {
            _bankAccountRepository = bankAccountRepository;
            _context = context;
        }

        public BankAccount GetById(int bankAccountId)
        {
            return _bankAccountRepository.GetById(bankAccountId);
        }

        public async Task<IEnumerable<BankAccount>> GetAllBankAccounts()
        {
            try
            {
                return await _bankAccountRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex; // Rethrow the exception
            }

        }

        public async Task CreateBankAccount(BankAccount bankAccount)
        {
            try
            {
                _bankAccountRepository.Add(bankAccount);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error creating user", ex);

            }
        }

        public void UpdateBankAccount(BankAccount bankAccount)
        {
           _bankAccountRepository.Update(bankAccount);
        }

        public Task DeleteBankAccount(int bankAccountId)
        {
            throw new NotImplementedException();
        }
    }
}
