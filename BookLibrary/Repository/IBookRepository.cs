using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface IBookRepository
    {
        List<BookModel> GetAllBooks();

        BookModel GetBookById(int i);
    }
}
