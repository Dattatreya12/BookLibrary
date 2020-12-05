using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly BookStoreContext _context = null;
        public LanguageRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguage()
        {
            return await _context.languages.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Name = x.Name,
                Descriptiom = x.Description
            }).ToListAsync();
        }

        public async Task<List<dropdownMonthly>> getmonths()
        {
            return await _context.dropdownMonthlies.Select(x => new dropdownMonthly()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<List<DropdownYearly>> getyears()
        {
            return await _context.dropdownYearlies.Select(x => new DropdownYearly()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
