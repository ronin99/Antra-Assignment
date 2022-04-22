using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Contract.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class GenreRepositorAsync:BaseRepositoryAsync<Genre>, IGenerRepositoryAsync
    {
        MovieContext context;
        public GenreRepositorAsync(MovieContext _db):base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            return await context.Genre.OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
