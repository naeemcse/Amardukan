using Amardukan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amardukan.Pages.Admin.Product
{
    public class IndexModel : PageModel
    {
        public ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context )
        {
            _context = context;
        }

        public List<Models.Product> Products { get; set; } = new List<Models.Product>(); 

        public void OnGet()
        {
           Products = _context.Products.OrderByDescending(p=>p.Id).ToList();
        }
    }
}
