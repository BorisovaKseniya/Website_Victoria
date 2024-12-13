using System.ComponentModel.DataAnnotations;

namespace Web_laba3.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
    
        public string? Surname { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }



    }
}
