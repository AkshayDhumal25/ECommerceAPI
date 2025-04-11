//namespace ECommerceAPI.Models
//{
//    public class User
//    {
//    }
//}
namespace ECommerceAPI.Models
{
    public class User
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PasswordHash { get; set; } // Optional until auth
        public bool IsDeleted { get; set; } = false;
    }
}
