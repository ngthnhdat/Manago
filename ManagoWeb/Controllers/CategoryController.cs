using ManagoWeb.Data;
using ManagoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagoWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View();
        }
    }
}
