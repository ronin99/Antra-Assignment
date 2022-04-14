using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;

namespace WebApplication1.Contracts.Repository
{
    public interface ICastRepositoryAsync : IRepositoryAsync<Cast>
    {
        Task<IEnumerable<Cast>> GetTop10CastAsync();
    }
}
