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
    public class MovieGenreServiceAsync : IMovieGenreServiceAsync
    {
        IMovieGenreRepositoryAsync context;
        public MovieGenreServiceAsync(IMovieGenreRepositoryAsync _ser)
        {
            context = _ser;
        }

        public async Task<int> AddMovieGenerAsync(MovieGenreModel model)
        {
            MovieGenre movieGenre = new MovieGenre();
            movieGenre.MovieId = model.MovieId;
            movieGenre.GenreId = model.GenreId;
            return await context.InsertAsync(movieGenre);
        }

        public async Task<int> DeleteMovieGenerAsync(int id)
        {
            return await context.DeleteAsync(id);   
        }

        public async Task<IEnumerable<MovieGenreModel>> GetAllAsync()
        {
            var result = await context.GetAllAsync();
            List<MovieGenreModel> lst = new List<MovieGenreModel>();
            foreach (var movie in result)
            {
                MovieGenreModel model = new MovieGenreModel();
                model.MovieId = movie.MovieId;
                model.GenreId = movie.GenreId;
                lst.Add(model);
            }
            return lst;
        }

        public async Task<IEnumerable<MovieGenreModel>> GetGenreByMovieIdAsync(int Id)
        {
            var result = await context.GetGenreByMovieIdAsync(Id);
            List<MovieGenreModel> genreList = new List<MovieGenreModel>();
            foreach (var item in result)
            {
                MovieGenreModel model = new MovieGenreModel();
                model.MovieId = item.MovieId;
                model.GenreId = item.GenreId;
                model.Genre = new GenreModel()
                {
                    Id = item.Genre.Id,
                    Name = item.Genre.Name
                };
                genreList.Add(model);
            }
            return genreList;
        }
    }
}
