using Microsoft.EntityFrameworkCore;

namespace AngularPojectBackend.data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option) 
        {
                
        }
		//protected override void OnConfiguring(DbContextOptionsBuilder option)
		//{
		//	option.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=projectdb; Integrated Security=True;TrustServerCertificate=True;");
		//	base.OnConfiguring(option);
		//}

        public DbSet<BankAccount> bankAccounts { get; set; }

    }
}
