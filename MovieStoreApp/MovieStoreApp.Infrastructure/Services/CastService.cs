using MovieStoreApp.Core.Models;
using MovieStoreApp.Contracts.Repository;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Contracts.Services
{
    public class CastServiceAsync : ICastServiceAsync
    {

        ICastRepositoryAsync context;
        public CastServiceAsync(ICastRepositoryAsync _ser)
        {
            context = _ser;
        }

        public async Task<int> AddCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.Gender = model.Gender;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath = model.ProfilePath;
            return await context.InsertAsync(c);
        }

        public async Task<int> DeleteCastAsync(int id)
        {
            return await context.DeleteAsync(id);
        }

        public async Task<CastModel> GetByIdAsync(int id)
        {
            var result = await context.GetAsync(id);
            if(result != null)
            {
                CastModel model = new CastModel();
                model.Id = result.Id;
                model.Name = result.Name;
                model.Gender = result.Gender;
                model.TmdbUrl = result.TmdbUrl;
                model.ProfilePath = result.ProfilePath;
                return model;
            }
            return null;
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
