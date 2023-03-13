using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Date;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class OrderModel : PageModel
    {
        public List<PizzaOrder> orders = new List<PizzaOrder>();
        
        private readonly ApplicationDBContext _context;
        public OrderModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            orders = _context.PizzaOrders.ToList();
        }


    }
    }
