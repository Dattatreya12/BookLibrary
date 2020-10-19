using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Models;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookrepository = null;

        public BookController(IBookRepository bookRepository)
        {
            _bookrepository = bookRepository;
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookrepository.GetAllBooks();
            return View(data);
        }

        public  IActionResult GetBook(int id)
        {
            var bookid = _bookrepository.GetBookById(id);
            return View(bookid);
        }
    }
}