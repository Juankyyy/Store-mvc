using Microsoft.AspNetCore.Mvc;
using Store_mvc.Data;
using Store_mvc.Models;
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

        public async Task<IActionResult> Delete(int? id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User u)
        {
            _context.Users.Update(u);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            var users = _context.Users.AsQueryable();

            if(!string.IsNullOrEmpty(search))
            {
                users = users.Where(u => u.Names.Equals(search));
            }

            return View(users.ToListAsync());
        }
    }
}