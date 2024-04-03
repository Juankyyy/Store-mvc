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
    }
}