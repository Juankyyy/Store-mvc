using Microsoft.EntityFrameworkCore;
using Store_mvc.Models;

namespace Store_mvc.Data
{
    public class Store_mvcContext : DbContext
    {
        public Store_mvcContext(DbContextOptions<Store_mvcContext> options) : base(options){

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}