using MovieStoreApp.Core.Models;
using WebApplication1.Contracts.Repository;
using WebApplication1.Infrastructure.Repository;

namespace WebApplication1.Contracts.Services
{
    public class CastServiceAsync : ICastServiceAsync
    {

        ICastRepositoryAsync m;
        public CastServiceAsync(ICastRepositoryAsync _se)
        {
            m = _se;
        }


       public async Task<IEnumerable<CastModel>> GetTop10CastAsync()
        {
            var result = await m.GetTop10CastAsync();
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
