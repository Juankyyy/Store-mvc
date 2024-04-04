using Microsoft.AspNetCore.Mvc;
using Store_mvc.Data;
using Microsoft.EntityFrameworkCore;

namespace Store_mvc.Controllers
{
    public class UsersController : Controller
    {
        public readonly Store_mvcContext _context;

        public UsersController(Store_mvcContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(User u)
        {
            _context.Users.Add(u);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}