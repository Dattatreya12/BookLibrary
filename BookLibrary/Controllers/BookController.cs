using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository<BookModel> _bookrepository;
        private readonly ILanguageRepository _languagerepository;
        private readonly IWebHostEnvironment _hostingenvironment;
        //private readonly BookRepository _br;


        public BookController(IBookRepository<BookModel> bookRepository, ILanguageRepository languagerepository, IWebHostEnvironment hostingenvironment)
        {
            _bookrepository = bookRepository;
            _languagerepository = languagerepository;
            _hostingenvironment = hostingenvironment;
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
        public async Task<IActionResult> AddNewBook(BookModel BM)
        {
            if (ModelState.IsValid)
            {
                if (BM.CoverPhoto != null)
                {
                    string folder = "Books/Cover/";
                    BM.CoverImageUrl = await UploadImage(folder, BM.CoverPhoto);
                }
                if (BM.GalleryFiles != null)
                {
                    string folder = "Books/Gallery";
                    BM.Gallery = new List<GalleryModel>();
                    foreach (var file in BM.GalleryFiles)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name = file.FileName,
                            URL = await UploadImage(folder, file)
                        };
                        BM.Gallery.Add(gallery); 
                    }
                }
                int id = await _bookrepository.Insert(BM);

                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true });
                }
            }
            ViewBag.languages = new SelectList(await _languagerepository.GetLanguage(), "Id", "Name");
            return View();
        }
        private async Task<string> UploadImage(string folderpath, IFormFile file)
        {
            folderpath += Guid.NewGuid().ToString() + "_" + file.FileName;
            //bm.CoverImageUrl = "/" + folder;
            string serverFolder = Path.Combine(_hostingenvironment.WebRootPath, folderpath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderpath;
        }

    }
}