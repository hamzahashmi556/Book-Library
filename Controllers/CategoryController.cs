using Book_Library.Database;
using Book_Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Library.Controllers {
    public class CategoryController : Controller {
        private ApplicationDbContext db;

        public CategoryController(ApplicationDbContext db) {
            this.db = db;
        }
        public IActionResult Index() {
            //var categories = db.Categories.ToList();
            IEnumerable<Category> categories = db.Categories;
            return View(categories);
        }
    }
}
