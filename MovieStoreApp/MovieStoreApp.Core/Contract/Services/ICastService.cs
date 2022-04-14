using MovieStoreApp.Core.Models;

namespace WebApplication1.Contracts.Services
{
    public interface ICastServiceAsync
    {
       Task<IEnumerable<CastModel>> GetTop10CastAsync();
    }
}
