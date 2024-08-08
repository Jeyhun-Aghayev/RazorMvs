using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor.Models;

namespace Razor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Razor.Data.RazorContext _context;

        public IndexModel(Razor.Data.RazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
