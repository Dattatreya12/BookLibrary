using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models.ViewModel
{
    public class BookModel
    {
        public Book book { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public string Category { get; set; }
        public int LanguageId { get; set; }
        public string Language { get; set; }

        public int TotalPages { get; set; }




    }
}
