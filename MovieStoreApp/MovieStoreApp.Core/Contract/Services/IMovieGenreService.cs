using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IMovieGenreServiceAsync
    {
        Task<IEnumerable<MovieGenreModel>> GetGenreByMovieIdAsync(int movieId);
        Task<IEnumerable<MovieGenreModel>> GetAllAsync();

        Task<int> AddMovieGenerAsync(MovieGenreModel model);
        Task<int> DeleteMovieGenerAsync(int id);
    }
}
