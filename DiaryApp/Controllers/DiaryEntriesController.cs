using DiaryApp.Data;
using Microsoft.AspNetCore.Mvc;
using DiaryApp.Models;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }
        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
