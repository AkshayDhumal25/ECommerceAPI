using System.Text.Json.Serialization;

namespace ECommerceAPI.Models
{
    public class Category
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for one-to-many relation

        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}

//namespace ECommerceAPI.Models
//{
//    public class Category
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        // Navigation property for one-to-many relation
//        public ICollection<Product>? Products { get; set; }
//    }
//}
