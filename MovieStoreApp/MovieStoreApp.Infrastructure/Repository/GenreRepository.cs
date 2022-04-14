using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
namespace MovieStoreApp.Infrastructure.Repository
{
    public class GenreRepositorAsync:BaseRepositoryAsync<Genre>
    {
        public GenreRepositorAsync(MovieContext _db):base(_db)
        {

        }
    }
}
