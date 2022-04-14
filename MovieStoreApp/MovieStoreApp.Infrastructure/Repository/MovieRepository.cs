using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure.Repository
{
    public class MovieRepositoryAsync:BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        MovieContext context;
        public MovieRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync()
        {
            return await context.Movie.OrderByDescending(x=>x.Revenue).Take(10).ToListAsync();
        }
    }
}