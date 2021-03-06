using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Models;
using System.Threading.Tasks;

namespace RazorExercise.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorExercise.Models.MovieContext _context;

        public CreateModel(RazorExercise.Models.MovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}