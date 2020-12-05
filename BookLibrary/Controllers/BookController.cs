using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository<Book> _bookrepository;
        private readonly ILanguageRepository _languagerepository;
        //private readonly BookRepository _br;


        public BookController(IBookRepository<Book> bookRepository, ILanguageRepository languagerepository /*BookRepository br*/)
        {
            _bookrepository = bookRepository;
            _languagerepository = languagerepository;
            //_br = br;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            ViewData["count"] = _bookrepository.GetBookTotalCount();
            //var data = await _br.GetAllBooks();
            var data = await _bookrepository.GetAllBooksfromBM();
            return View(data);
        }

        public IActionResult GetBook(int id)
        {

            var bookid = _bookrepository.GetBookById(id);
            return View(bookid);
        }


        public async Task<IActionResult> AddNewBook(bool isSuccess = false)
        {
            ViewBag.languages = new SelectList(await _languagerepository.GetLanguage(), "Id", "Name");
            ViewBag.success = isSuccess;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(Book BM)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                id = await _bookrepository.Insert(BM);
            }

            if (id > 0)
            {
                ViewBag.languages = new SelectList(await _languagerepository.GetLanguage(), "Id", "Name");
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true });
            }
            else
            {
                ViewBag.languages = new SelectList(await _languagerepository.GetLanguage(), "Id", "Name");
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = false });
            }
        }



    }
}