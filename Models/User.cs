//namespace ECommerceAPI.Models
//{
//    public class User
//    {
//    }
//}
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Models
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }  // Primary Key
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? PasswordHash { get; set; } // Optional until auth
        [JsonIgnore]
        public bool IsDeleted { get; set; } = false;
    }
}
