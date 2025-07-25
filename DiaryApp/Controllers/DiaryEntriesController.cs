using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(string search, string sort)
        {
            var entries = _db.DiaryEntries.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                entries = entries.Where(e => EF.Functions.Like(e.Title, $"%{search}%") || EF.Functions.Like(e.Content, $"%{search}%"));
            }

            entries = sort switch
            {
                "title" => entries.OrderBy(e => e.Title),
                "date" => entries.OrderByDescending(e => e.Creation),
                _ => entries.OrderByDescending(e => e.Creation)
            };

            return View(entries.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DiaryEntry entry)
        {
            if (ModelState.IsValid)
            {
                entry.Creation = DateTime.Now;
                _db.DiaryEntries.Add(entry);
                _db.SaveChanges();
                TempData["SuccessMessage"] = "Diary entry created successfully!";
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        public IActionResult Edit(int id)
        {
            var entry = _db.DiaryEntries.Find(id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DiaryEntry entry)
        {
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(entry);
                _db.SaveChanges();
                TempData["SuccessMessage"] = "Diary entry updated successfully!";
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        public IActionResult Delete(int id)
        {
            var entry = _db.DiaryEntries.Find(id);
            if (entry == null)
            {
                return NotFound();
            }
            _db.DiaryEntries.Remove(entry);
            _db.SaveChanges();
            TempData["SuccessMessage"] = "Diary entry deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}