using ManagoWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace ManagoWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;
        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
