using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data;
using ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Models;

namespace ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data.ITMOASPNET_Lab02Ex1_RazorPagesMovieContext _context;

        public CreateModel(ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data.ITMOASPNET_Lab02Ex1_RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
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
