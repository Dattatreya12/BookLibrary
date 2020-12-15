using BookLibrary.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models.ViewModel
{
    public class BookModel : Book
    {
        public IFormFile CoverPhoto { get; set; }
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }

    }
}
