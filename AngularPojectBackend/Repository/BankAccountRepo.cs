using AngularPojectBackend.data;
using AngularPojectBackend.Intreface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AngularPojectBackend.Repository
{
	public class BankAccountRepo : IBankAccount
	{
		private readonly AppDbContext _appDbContext;

        public BankAccountRepo(AppDbContext appDbContext)
        {
				_appDbContext = appDbContext;
        }
        public void AddBankAccoun(BankAccount bankAccount)
		{
			var bank = _appDbContext.bankAccounts.Add(bankAccount);
			 _appDbContext.SaveChangesAsync();
		}

		public void DeleteBankAccount(int accountId)
		{
			var bank = _appDbContext.bankAccounts.SingleOrDefault(i => i.accountId == accountId);
			_appDbContext.bankAccounts.Remove(bank);
			_appDbContext.SaveChanges();
		}

		public async Task<BankAccount> GetBankAccountById(int accountId)
		{
			var bank = await _appDbContext.bankAccounts.SingleOrDefaultAsync(i => i.accountId == accountId);
			return bank;
		}

		public async Task<IEnumerable<BankAccount>> GetBankAccounts()
		{
			var bankAccounts = await _appDbContext.bankAccounts.ToListAsync();
			return bankAccounts;
		}

		public void UpdateBankAccount(BankAccount bankAccount)
		{
			var bankaccount = _appDbContext.bankAccounts.Update(bankAccount);
			_appDbContext.SaveChangesAsync();
		}
	}
}
