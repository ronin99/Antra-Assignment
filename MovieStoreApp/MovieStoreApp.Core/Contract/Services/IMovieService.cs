using MovieStoreApp.Core.Models;
namespace MovieStoreApp.Contracts.Services
{
    //in response you dont have to define relationship
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetTop12RevenueMoviesAsync();
        Task<MovieResponseModel> GetByIdAsync(int id);
    }
}
