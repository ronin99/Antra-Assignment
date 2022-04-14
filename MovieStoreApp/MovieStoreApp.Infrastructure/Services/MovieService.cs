using MovieStoreApp.Core.Models;
using WebApplication1.Contracts.Repository;
using WebApplication1.Contracts.Services;

namespace WebApplication1.Infrastructure.Services
{
    public class MovieServiceAsync : IMovieServiceAsync
    {
        IMovieRepositoryAsync movieRepository;
        // that imovierepository put it in here will create a object of moviereposiotry that ref to the builder.scop
        public MovieServiceAsync(IMovieRepositoryAsync _m)
        {
            movieRepository = _m;
        }
        public async Task<MovieResponseModel> GetByIdAsync(int id)
        {
            MovieResponseModel model = new MovieResponseModel();
            var movie = await movieRepository.GetAsync(id);
            if(movie != null)
            {
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.ImdbUrl = movie.ImdbUrl;
                model.BackdropUrl = movie.BackdropUrl;
                model.OriginalLanguage = movie.OriginalLanguage;
                model.PosterUrl = movie.PosterUrl;
                model.Tagline = movie.Tagline;
                model.Price = movie.Price;
                model.Title = movie.Title;
                model.Budget = movie.Budget;
                model.Revenue = movie.Revenue;
                model.ReleaseDate = movie.ReleaseDate;
                model.Runtime = movie.Runtime;
                model.TmdbUrl = movie.TmdbUrl;

            }
            return model;
        }

        public async Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync()
        {
            var result = await movieRepository.GetTop10RevenueMoviesAsync();
            List<MovieResponseModel> lst = new List<MovieResponseModel>();
            foreach (var movie in result)
            {
                MovieResponseModel model = new MovieResponseModel();
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.ImdbUrl = movie.ImdbUrl;
                model.BackdropUrl = movie.BackdropUrl;
                model.OriginalLanguage = movie.OriginalLanguage;
                model.PosterUrl = movie.PosterUrl;
                model.Tagline = movie.Tagline;
                model.Price = movie.Price;
                model.Title = movie.Title;
                model.Budget = movie.Budget;
                model.Revenue = movie.Revenue;
                model.ReleaseDate = movie.ReleaseDate;
                model.Runtime = movie.Runtime;
                model.TmdbUrl = movie.TmdbUrl;
                lst.Add(model);
          


            }
            return lst;
        }
    }
}
