using PizzeriaPlace.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaPlace.BLL
{
    public class MenuL
    {
        public List<Pizzas1> Pizzas { get; set; } = new List<Pizzas1>();
        public void Add(Pizzas1 pizzas) => Pizzas.Add(pizzas);
        public Pizzas1? ObtenerPizzas(int id) => Pizzas.SingleOrDefault(p => p.Id == id);
    }
}
