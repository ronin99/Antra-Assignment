using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Contract.Repository;
namespace WebApplication1.Contracts.Repository
{
    //class for the method of the movie
    public interface IMovieRepositoryAsync: IRepositoryAsync<Movie>
    {
        Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync();
      
    }
}
