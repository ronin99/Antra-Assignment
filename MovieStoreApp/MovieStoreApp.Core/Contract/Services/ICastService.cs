using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Contracts.Services
{
    public interface ICastServiceAsync
    {
       Task<IEnumerable<CastModel>> GetTop10CastAsync();
        Task<CastModel> GetByIdAsync(int id);

        Task<int> AddCastAsync(CastModel cast);

        Task<int> DeleteCastAsync(int id);
    }
}
