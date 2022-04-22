using MovieStoreApp.Core.Models;
namespace MovieStoreApp.Contracts.Services
{
    //in response you dont have to define relationship
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetTop12RevenueMoviesAsync();
        Task<MovieResponseModel> GetByIdAsync(int id);
        Task<IEnumerable<MovieResponseModel>> MoviesByGenreAsync(int movieId, int pagesize = 30, int pageNumber = 1);

        Task<int> AddMovieAsync(MovieResponseModel model);

        Task<int> DeleteMovieAsync(int id);
    }
}
