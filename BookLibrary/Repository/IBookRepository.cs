using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface IBookRepository<T>
    {
        Task<List<T>> GetAllBooks();

        Task<List<BookModel>> GetAllBooksfromBM();
        Book GetBookById(int i);
        int GetBookTotalCount();

        Task<int> Insert(T item);
    }
}
