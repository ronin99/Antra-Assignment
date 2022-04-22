using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Contracts.Services
{
    public interface IGenreServiceAsync
    {
        Task<GenreModel> GetByIdAsync(int id);
        Task<IEnumerable<GenreModel>> GetAllAsync();

        Task<int> AddGenreAsync(GenreModel genre);
        Task<int> DeleteGenreAsync(int id);
    }
}
