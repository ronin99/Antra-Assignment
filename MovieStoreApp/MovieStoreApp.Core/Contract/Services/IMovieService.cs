using MovieStoreApp.Core.Models;
namespace WebApplication1.Contracts.Services
{
    //in response you dont have to define relationship
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync();
        Task<MovieResponseModel> GetByIdAsync(int id);
    }
}
