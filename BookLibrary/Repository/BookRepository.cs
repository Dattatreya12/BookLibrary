using BookLibrary.Models;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository:IBookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="C#",Author="Datta",Description="in the yeat 200 we have wtote this book"},
                 new BookModel(){Id=1,Title="DBMS",Author="Datta", Description="in the yeat 200 we have wtote this book"},
                  new BookModel(){Id=1,Title="Dot.Net Core",Author="Dr,RAMA",Description="in the yeat 200 we have wtote this book"},
                 new BookModel(){Id=1,Title="PYTHON",Author="Padmanabh", Description="in the yeat 200 we have wtote this book"},
            };
        }
    }
}
