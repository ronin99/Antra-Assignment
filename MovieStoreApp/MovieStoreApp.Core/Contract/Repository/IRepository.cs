﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IRepositoryAsync<T>where T : class
    {
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
    }
}
