using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface IBhagyastoreRepoitory<T>
    {
        Task<int> Insert(T item);
        Task<List<Bhagyastorage>> GetAllUsage();
        Bhagyastorage GetTotalAmount();
    };
}
