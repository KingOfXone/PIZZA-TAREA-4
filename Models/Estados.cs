using PizzeriaPlace.BLL;

namespace PizzeriaPlace.Models
{
    public class Estados
    {
        public MenuL Menu { get; set; }  = new MenuL();
        public CestaDCompras cestaDCompras { get; set; } = new CestaDCompras();
        public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
        public decimal PrecioTotal => cestaDCompras.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);


    }
}
