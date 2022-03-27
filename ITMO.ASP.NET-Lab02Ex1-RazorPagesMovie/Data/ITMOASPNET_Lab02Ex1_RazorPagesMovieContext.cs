using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Models;

namespace ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Data
{
    public class ITMOASPNET_Lab02Ex1_RazorPagesMovieContext : DbContext
    {
        public ITMOASPNET_Lab02Ex1_RazorPagesMovieContext (DbContextOptions<ITMOASPNET_Lab02Ex1_RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
