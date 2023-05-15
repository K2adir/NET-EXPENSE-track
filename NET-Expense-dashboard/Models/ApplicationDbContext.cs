using Microsoft.EntityFrameworkCore;

namespace NET_Expense_dashboard.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{

		}
		public DbSet<Transaction> Tranactions { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}

