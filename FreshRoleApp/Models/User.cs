using System.ComponentModel.DataAnnotations;

namespace FreshRoleApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        // To grab job associated with user
        public Job? Job { get; set; }
    }
}
