using System.ComponentModel.DataAnnotations;

namespace SplitAppAPI.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public string ExpenseName { get; set; }
    }
}
