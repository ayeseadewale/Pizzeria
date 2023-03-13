using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class pizzaModel : PageModel
    {
        public List<PizzasModel> fakeDb = new List<PizzasModel>(){
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = false,
                Mushroom = false,
                Pineapple = false,
                Ham = false,
                Beef = false,
                Tuna = false,
                FinalPrice = 10
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = true,
                Mushroom = false,
                Pineapple = false,
                Ham = false,
                Beef = false,
                Tuna = false,
                FinalPrice = 10
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = false,
                Mushroom = false,
                Pineapple = true,
                Ham = true,
                Beef = false,
                Tuna = false,
                FinalPrice = 10
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = true,
                Mushroom = true,
                Pineapple = false,
                Ham = true,
                Beef = true,
                Tuna = false,
                FinalPrice = 10
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = false,
                Mushroom = true,
                Pineapple = true,
                Ham = false,
                Beef = false,
                Tuna = false,
                FinalPrice = 10
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = false,
            },
             new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 10,
                TomatoesSauce = true,
                Cheese = true,
                Peperoni = false,
            }
            };
        public void OnGet()
        {
        }
    }
}
