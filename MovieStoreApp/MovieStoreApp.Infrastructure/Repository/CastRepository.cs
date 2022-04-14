using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using WebApplication1.Contracts.Repository;

namespace WebApplication1.Infrastructure.Repository
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
            return await context.Cast.Take(10).ToListAsync();
        }
    }
}
