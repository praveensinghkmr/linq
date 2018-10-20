﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie { Title = "Casablanca", Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star Wars V", Rating = 8.9f, Year = 1980 },
            };

            var query = Enumerable.Empty<Movie>();
            try
            {
                query = movies.Filter(m => m.Year > 2000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(query.Count());
            foreach (var movie in query)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
