using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Services
{
    public interface IMovieCastServiceAsync
    {
        Task<IEnumerable<MovieCastModel>> GetAllByMovieIdAsync(int movieId);
        Task<IEnumerable<MovieCastModel>> GetAllAsync();

        Task<int> AddMovieCastAsync(MovieCastModel model);
        Task<int> DeleteMovieCastAsync(int id);
        
        Task<MovieCastModel> GetMovieCastByIdAsync(int id);
    }
}
