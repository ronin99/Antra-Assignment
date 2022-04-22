﻿using MovieStoreApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IMovieGenreRepositoryAsync: IRepositoryAsync<MovieGenre>
    {
        Task<IEnumerable<MovieGenre>> GetGenreByMovieIdAsync(int movieId);
        Task<IEnumerable<MovieGenre>> GetAllAsync();


    }
}
