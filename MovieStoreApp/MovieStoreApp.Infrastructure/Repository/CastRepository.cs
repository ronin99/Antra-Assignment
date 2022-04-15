using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>,ICastRepositoryAsync
    {
        MovieContext context;
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }

        public async Task<IEnumerable<Cast>> GetTop10CastAsync()
        {
            return await context.Cast.OrderByDescending(x => x.Name).Take(12).ToListAsync();
        }
    }
}
