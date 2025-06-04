using System.ComponentModel.DataAnnotations;

namespace Amardukan.Models
{
    public class Product
    {
        public int Id { get ;set; }
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")] 
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Brand { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative.")]
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
