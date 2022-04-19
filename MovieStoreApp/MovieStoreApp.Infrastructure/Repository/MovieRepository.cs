using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository
{
    //this will connect to the database and select the data 
    public class MovieRepositoryAsync:BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        MovieContext context;
        public MovieRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<Movie>> GetTop12RevenueMoviesAsync()
        {
            return await context.Movie.OrderByDescending(x=>x.Revenue).ToListAsync();
        }

        
    }
}