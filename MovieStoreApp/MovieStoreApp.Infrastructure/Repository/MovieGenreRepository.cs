
using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class MovieGenreRepositoryAsync : BaseRepositoryAsync<MovieGenre>, IMovieGenreRepositoryAsync
    {
        private readonly MovieContext context;
        public MovieGenreRepositoryAsync(MovieContext _db):base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<MovieGenre>> GetGenreByMovieIdAsync(int Id)
        {
            return await context.MovieGenre.Include("Genre").Where(x => x.MovieId == Id).ToListAsync();
        }

        public async Task<IEnumerable<MovieGenre>> GetAllAsync()
        {
            return await context.MovieGenre.OrderByDescending(x => x.MovieId).ToListAsync();
        }
    }
}
