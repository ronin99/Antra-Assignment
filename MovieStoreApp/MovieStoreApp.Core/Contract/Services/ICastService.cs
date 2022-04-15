using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Contracts.Services
{
    public interface ICastServiceAsync
    {
       Task<IEnumerable<CastModel>> GetTop10CastAsync();
    }
}
