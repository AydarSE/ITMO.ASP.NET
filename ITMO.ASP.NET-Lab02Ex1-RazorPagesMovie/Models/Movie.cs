using System;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASP.NET_Lab02Ex1_RazorPagesMovie.Models

{
    public class Movie
    {
            public int ID { get; set; }
            public string Title { get; set; }
            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }
            public decimal Price { get; set; }
        
    }
}

