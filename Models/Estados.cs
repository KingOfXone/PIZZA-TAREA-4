using PizzeriaPlace.BLL;

namespace PizzeriaPlace.Models
{
    public class Estados
    {
        public MenuL Menu { get; set; }  = new MenuL();
        public CarritoCompras CarritoCompras { get; set; } = new CarritoCompras();
        public IUsuario Interfaz { get; set; } = new IUsuario();
        public decimal PrecioTotal => CarritoCompras.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);


    }
}
