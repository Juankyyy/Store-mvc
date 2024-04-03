using Microsoft.AspNetCore.Mvc;
using Store_mvc.Data;
using Microsoft.EntityFrameworkCore;

namespace Store_mvc.Controllers
{
    public class ProductsController : Controller
    {
        public readonly Store_mvcContext _context;

        public ProductsController(Store_mvcContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.Products.FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return View(await _context.Products.FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}