using System.ComponentModel.DataAnnotations;

namespace Amardukan.Models
{
    public class ProductDTO
    {
     
        [Required, StringLength(100)]   
        public string Name { get; set; } 
        [StringLength(500)]
        public string ? Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string? Category { get; set; } 
        public string? Brand { get; set; } 
        public string? ImageUrl { get; set; }       
        public int? StockQuantity { get; set; }
    }
}
