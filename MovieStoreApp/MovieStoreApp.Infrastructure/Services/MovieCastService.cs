using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Services
{
    public class MovieCastServiceAsync : IMovieCastServiceAsync
    {
        IMovieCastRepositoryAsync movieCastrepository;
        public MovieCastServiceAsync(IMovieCastRepositoryAsync _movie)
        {
            movieCastrepository = _movie;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieIdAsync(int movieId)
        {
            var result = await movieCastrepository.GetAllByMovieIdAsync(movieId);
            List<MovieCastModel> list = new List<MovieCastModel>();
            foreach (var item in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.Id = item.Id;
                model.CastId = item.CastId;
                model.Cast = new CastModel()
                {
                    Id = item.Cast.Id,
                    Gender = item.Cast.Gender,
                    Name = item.Cast.Name,
                    ProfilePath = item.Cast.ProfilePath,
                    TmdbUrl = item.Cast.TmdbUrl
                };
                list.Add(model);
            }
            return list;
            
        }
    }
}
