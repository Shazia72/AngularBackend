namespace AngularPojectBackend.Intreface
{
	public interface IBankAccount
	{
		Task<IEnumerable<BankAccount>> GetBankAccounts();
		Task<BankAccount> GetBankAccountById(int id);
		void AddBankAccoun(BankAccount bankAccount);
		void DeleteBankAccount(int id);
		void UpdateBankAccount(BankAccount bankAccount);

	}
}
