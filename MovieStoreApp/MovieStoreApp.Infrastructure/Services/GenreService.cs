using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Contracts.Services
{
    public class GenreServiceAsync : IGenreServiceAsync
    {
        IGenerRepositoryAsync genreService;
        public GenreServiceAsync(IGenerRepositoryAsync _ser)
        {
            genreService = _ser;
        }

        public async Task<int> AddGenreAsync(GenreModel genre)
        {
            Genre g = new Genre();
            g.Name = genre.Name;
            return await genreService.InsertAsync(g);
        }

        public async Task<int> DeleteGenreAsync(int id)
        {
            return await genreService.DeleteAsync(id);
        }

        public async Task<IEnumerable<GenreModel>> GetAllAsync()
        {
           var result = await genreService.GetAllAsync();
           List<GenreModel> lst = new List<GenreModel>();
        foreach (var item in result)
            {
                GenreModel model = new GenreModel();
                model.Name = item.Name;
                lst.Add(model);
            }
            return lst;
        }

        public async Task<GenreModel> GetByIdAsync(int id)
        {
            var result = await genreService.GetAsync(id);
            if(result != null)
            {
                GenreModel model = new GenreModel();
                model.Id = result.Id;
                model.Name = result.Name;
                return model;
            }
            return null;
        }
    }
}
