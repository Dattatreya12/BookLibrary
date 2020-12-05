using BookLibrary.Models;
using BookLibrary.Models.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguage();
        Task<List<dropdownMonthly>> getmonths();
        Task<List<DropdownYearly>> getyears();
    }
}