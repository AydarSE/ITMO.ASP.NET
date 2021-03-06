using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data;
using ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Models;

namespace ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data.ITMOASPNET_Lab02Ex1_RazorPagesMovieContext _context;

        public IndexModel(ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data.ITMOASPNET_Lab02Ex1_RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
