using MovieStoreApp.Core.Models;
using MovieStoreApp.Contracts.Repository;
using MovieStoreApp.Infrastructure.Repository;

namespace MovieStoreApp.Contracts.Services
{
    public class CastServiceAsync : ICastServiceAsync
    {

        ICastRepositoryAsync context;
        public CastServiceAsync(ICastRepositoryAsync _ser)
        {
            context = _ser;
        }


       public async Task<IEnumerable<CastModel>> GetTop10CastAsync()
        {
            var result = await context.GetTop10CastAsync();
            List<CastModel> lst = new List<CastModel>();
            foreach (var movie in result)
            {
                CastModel model = new CastModel();
                model.Id = movie.Id;
                model.Name = movie.Name;
                model.Gender = movie.Gender;
                model.TmdbUrl = movie.TmdbUrl;
                model.ProfilePath = movie.ProfilePath;
               lst.Add(model);
            }
            return lst;
        }
     
    }
}
