using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Surname { get; set; }
        [Required]
        public required bool Gender { get; set; }
        [Required]
        public required DateTime BirthDate { get; set; }
        public int TelephoneNumber { get; set; }
        public string? Position { get; set; }
        public int ShoeSize { get; set; }
        public User()
        {
                
        }
    }
}
