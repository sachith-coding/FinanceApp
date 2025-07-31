using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public byte[] PasswordHash { get; set; } = null!;
        [Required]
        public byte[] PasswordSalt { get; set; } = null!;
    }
}
