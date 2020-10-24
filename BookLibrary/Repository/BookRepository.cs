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

        public int GetBookTotalCount()
        {
            var count = DataSource().Count();
            return count;

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="C#",Author="Datta",Description="in the yeat 200 we have wtote this book",price=1000},
                 new BookModel(){Id=2,Title="DBMS",Author="Datta", Description="in the yeat 200 we have wtote this book",price=500},
                  new BookModel(){Id=3,Title="Dot.Net Core",Author="Dr,RAMA",Description="in the yeat 200 we have wtote this book",price=800},
                 new BookModel(){Id=4,Title="PYTHON",Author="Padmanabh", Description="in the yeat 200 we have wtote this book",price=700},
                   new BookModel(){Id=5,Title="JAVA",Author="Datta", Description="in the yeat 200 we have wtote this book",price=2000},
                  new BookModel(){Id=6,Title="Programming Language",Author="Dr,RAMA",Description="in the yeat 200 we have wtote this book",price=4000},
                 new BookModel(){Id=7,Title="PHP",Author="Padmanabh", Description="in the yeat 200 we have wtote this book" ,price=1000},
            };
        }
    }
}
