using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.Date
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }
}
