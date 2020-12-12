using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.CommonConnection;
using BookLibrary.Models;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookLibrary.Controllers
{
    public class UsageController : Controller
    {
        private readonly ILanguageRepository _languageRepository = null;
        private readonly IBhagyastoreRepoitory<Bhagyastorage> _bhagyastoreRepoitory;
        public UsageController(ILanguageRepository languageRepository, IBhagyastoreRepoitory<Bhagyastorage> bhagyastoreRepoitory)
        {
            _languageRepository = languageRepository;
            _bhagyastoreRepoitory = bhagyastoreRepoitory;
        }
        public async Task<IActionResult> Index()
        {

            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            //ViewBag.monthly = new SelectList(await _languageRepository.getsqlmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            var Totalusagecalculate = _bhagyastoreRepoitory.GetTotalAmount();
            ViewBag.totalusagefromlast = Totalusagecalculate.Tamount;
            return View();
        }

        [HttpGet]
        public async Task<ViewResult> AddNewUsage()
        {
            var data = await _bhagyastoreRepoitory.GetAllUsage();
            return View(data);
        }

        public async Task<PartialViewResult> Employee()
        {
            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            //ViewBag.monthly = new SelectList(await _languageRepository.getsqlmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            var Totalusagecalculate = _bhagyastoreRepoitory.GetTotalAmount();
            if (Totalusagecalculate == null)
            {
                return PartialView("_UsageInsert");
            }
            else
            {
                ViewBag.totalusagefromlast = Totalusagecalculate.Tamount;
                return PartialView("_UsageInsert");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUsage(Bhagyastorage bs)
        {

            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            //ViewBag.monthly = new SelectList(await _languageRepository.getsqlmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            int id = 0;
            if (ModelState.IsValid)
            {
                id = await _bhagyastoreRepoitory.Insert(bs);
            }
            else
            {
                return View("AddNewUsage");
            }
            return RedirectToAction("AddNewUsage");
        }

        public async Task<IActionResult> GetMonth()
        {
            ViewBag.monthly = new SelectList(await _languageRepository.getmonths(), "Id", "Name");
            ViewBag.yearly = new SelectList(await _languageRepository.getyears(), "Id", "Name");
            return View();
        }
    }
}