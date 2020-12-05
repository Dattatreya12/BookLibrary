using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<daycode> daycodes { get; set; }
        public DbSet<LoanUsers> loanUsers { get; set; }
        public DbSet<dropdownMonthly> dropdownMonthlies { get; set; }
        public DbSet<DropdownYearly> dropdownYearlies { get; set; }


    }
}
