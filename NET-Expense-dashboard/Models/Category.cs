using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NET_Expense_dashboard.Models;

public class Category
{
	[Key]
	public int CategoryId { get; set; }

	[Column(TypeName = "nvarchat(50)")]
	public string Title { get; set; }

	[Column(TypeName = "nvarchat(5)")]
	public string Icon { get; set; } = "";

	[Column(TypeName = "nvarchar(10)")]
	public string Type { get; set; } = "Expense";
}

