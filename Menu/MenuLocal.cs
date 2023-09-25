using Pizzeria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.BLL
{
    public class MenuLocal
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizzas) => Pizzas.Add(pizzas);
        public Pizzas? ObtenerPizzas(int id) => Pizzas.SingleOrDefault(p => p.Id == id);
    }
}
