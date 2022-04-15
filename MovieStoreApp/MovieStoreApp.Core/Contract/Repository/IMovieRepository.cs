using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Contract.Repository;
namespace MovieStoreApp.Contracts.Repository
{
    //class for the method of the movie
    public interface IMovieRepositoryAsync: IRepositoryAsync<Movie>
    {
        Task<IEnumerable<Movie>> GetTop12RevenueMoviesAsync();
      
    }
}
