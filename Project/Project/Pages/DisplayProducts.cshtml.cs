using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Pages
{
    public class DisplayProductsModel : PageModel
    {
        public string PriceSort { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        private readonly Project.Data.ProjectContext _context;

        public DisplayProductsModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync(string SortOrder, string searchString)
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
            PriceSort = String.IsNullOrEmpty(SortOrder) ? "price_desc" : "";

            CurrentFilter = searchString;

            IQueryable<Product> studentsIQ = from s in _context.Product
                                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.ProductName.Contains(searchString)
                                       );
            }

            switch (SortOrder)
            {
                case "price_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Price);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.Price);
                    break;

            }

            Product = await studentsIQ.AsNoTracking().ToListAsync();
        }
    }

}



