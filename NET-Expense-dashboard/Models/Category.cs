using System.ComponentModel.DataAnnotations;
namespace NET_Expense_dashboard.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public string Title { get; set; }
		public string Icon { get; set; }
		public string Type { get; set; }
	}
}

