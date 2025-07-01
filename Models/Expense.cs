using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Range(0.01, double.MaxValue, ErrorMessage = "AMount is not in the given range")] 
        [Required]
        public double Amount { get; set; }
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
