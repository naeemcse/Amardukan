using Amardukan.Data;
using Amardukan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Amardukan.Pages.Admin.Product
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProductDTO Product { get; set; } = new ProductDTO();
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public ApplicationDbContext _context;
        public  CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }


      
        public void OnGet()
        {
            // Example: Hardcoded categories. Replace with DB/service call as needed.
            Categories = new List<SelectListItem>
            {
                new SelectListItem { Value = "Electronics", Text = "Electronics" },
                new SelectListItem { Value = "Audio", Text = "Audio" },
                new SelectListItem { Value = "Home Appliances", Text = "Home Appliances" },
                new SelectListItem { Value = "Fitness", Text = "Fitness" },
                new SelectListItem { Value = "Wearables", Text = "Wearables" }
            };
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Repopulate categories if validation fails
                OnGet();
                return Page();
            }


            // Save logic here
            _context.Products.Add(new Models.Product
            {
                Name = Product.Name,
                Description = Product.Description ?? string.Empty,
                Price = Product.Price,
                Category = Product.Category ?? string.Empty,
                Brand = Product.Brand ?? string.Empty,
                ImageUrl = Product.ImageUrl ?? string.Empty,
                StockQuantity = Product.StockQuantity ?? 0,
                CreatedAt = DateTime.UtcNow
            });
            _context.SaveChanges();


            return RedirectToPage("./Index");
        }
    }
}

