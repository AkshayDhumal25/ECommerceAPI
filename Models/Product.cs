//namespace ECommerceAPI.Models
//{
//    public class Product
//    {
//    }
//}

namespace ECommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        // Foreign Key to Category
        public int CategoryId { get; set; }

        // Navigation Property
        public Category? Category { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
