using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; } = null!;
        [Range(0.01, double.MaxValue, ErrorMessage = "AMount is not in the given range")] 
        [Required]
        public double Amount { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
