using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository : IBookRepository<BookModel>
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {

            var books = new List<BookModel>();
            // var allbooks = await _context.Books.ToListAsync();
            var allbooks = await (from iint in _context.Books
                                  join n in _context.languages on iint.LanguageId equals n.Id

                                  select new
                                  {
                                      n.Name,
                                      iint.Title,
                                      iint.Author,
                                      iint.Description,
                                      iint.price,
                                      iint.LanguageId,
                                      iint.Id
                                  }

                                  ).ToListAsync();

            if (allbooks?.Any() == true)
            {
                foreach (var book1 in allbooks)
                {
                    books.Add(new BookModel()
                    {

                        Title = book1.Title,
                        Author = book1.Author,
                        price = book1.price,
                        Description = book1.Description,
                        LanguageId = book1.LanguageId,
                        Language = book1.Name,
                        Id = book1.Id

                    });
                }
            }

            return books;
        }

        public async Task<List<BookModel>> GetAllBooksfromBM()
        {
            var books = new List<BookModel>();
            // var allbooks = await _context.Books.ToListAsync();
            var allbooks = await (from iint in _context.Books
                                  join n in _context.languages on iint.LanguageId equals n.Id

                                  select new
                                  {
                                      n.Name,
                                      iint.Title,
                                      iint.Author,
                                      iint.Description,
                                      iint.price,
                                      iint.LanguageId,
                                      iint.Id,
                                      iint.CoverImageUrl,
                                  }

                                  ).ToListAsync();

            if (allbooks?.Any() == true)
            {
                foreach (var book1 in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Title = book1.Title,
                        Author = book1.Author,
                        price = book1.price,
                        Description = book1.Description,
                        LanguageId = book1.LanguageId,
                        Language = book1.Name,
                        Id = book1.Id,
                        CoverImageUrl = book1.CoverImageUrl,

                    });
                }
            }

            return books;
        }

        public Book GetBookById(int id)
        {
            Book empDetails = (from emp in _context.Books
                               join us in _context.languages on emp.LanguageId equals us.Id
                               where emp.Id == id
                               select new BookModel
                               {
                                   Title = emp.Title,
                                   Author = emp.Author,
                                   Id = emp.Id,
                                   Description = emp.Description,
                                   price = emp.price,
                                   CoverImageUrl = emp.CoverImageUrl,
                                   Gallery = emp.bookGallery.Select(x => new GalleryModel()
                                   {
                                       Id = x.Id,
                                       Name = x.Name,
                                       URL = x.URL
                                   }).ToList()
                               }).FirstOrDefault();

            return empDetails;
            //return _context.Books.Where(x => x.Id == id).FirstOrDefault();
        }


        public int GetBookTotalCount()
        {
            // var count = DataSource().Count();
            return 0;

        }

        public async Task<int> Insert(BookModel item)
        {
            var newbook = new Book()
            {
                Title = item.Title,
                Author = item.Author,
                Description = item.Description,
                price = item.price,
                TotalPages = item.TotalPages,
                LanguageId = item.LanguageId,
                Category = item.Category,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = item.CoverImageUrl,
            };

            newbook.bookGallery = new List<BookGallery>();

            foreach (var file in item.Gallery)
            {
                newbook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newbook);
            await _context.SaveChangesAsync();
            return newbook.Id;
        }
    }
}
