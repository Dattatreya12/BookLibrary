using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookLibrary.Controllers
{
    public class UsageController : Controller
    {
        private readonly ILanguageRepository _languageRepository = null;
        public UsageController(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public async Task<IActionResult> Index()
        {

            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            return View();
        }

        public async Task<IActionResult> GetMonth()
        {

            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            return View();
        }
    }
}