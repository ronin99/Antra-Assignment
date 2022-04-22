using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Entity;
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

        public async Task<IEnumerable<MovieCastModel>> GetAllAsync()
        {
            var result = await movieCastrepository.GetAllAsync();
            List<MovieCastModel> list = new List<MovieCastModel>();
            foreach (var item in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.MovieId = item.MovieId;
                model.CastId = item.CastId;
                model.Character = item.Character;
                list.Add(model);
            }
            return list;
        }

        public async Task<int> AddMovieCastAsync(MovieCastModel model)
        {
            MovieCast m = new MovieCast();
            m.CastId = model.CastId;
            m.Character = model.Character;
            m.MovieId = model.MovieId;
            return await movieCastrepository.InsertAsync(m);
        }

        public async Task<int> DeleteMovieCastAsync(int id)
        {
           return await movieCastrepository.DeleteAsync(id);
        }

        public async Task<MovieCastModel> GetMovieCastByIdAsync(int id)
        {
            var result = await movieCastrepository.GetAsync(id);
            if(result != null)
            {
                MovieCastModel model = new MovieCastModel();
                model.MovieId = result.MovieId;
                model.CastId = result.CastId;
                model.Character = result.Character;
                return model;
            }
            return null;
        }


    }
}
