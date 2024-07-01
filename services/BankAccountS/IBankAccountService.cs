using prov.Models;

namespace prov.services.BankAccountS
{
    public interface IBankAccountService
    {
        BankAccount GetById(int bankAccountId);
        Task<IEnumerable<BankAccount>> GetAllBankAccounts();
        Task CreateBankAccount(BankAccount bankAccount);
        void UpdateBankAccount(BankAccount bankAccount);
        Task DeleteBankAccount(int bankAccountId);
    }
}
