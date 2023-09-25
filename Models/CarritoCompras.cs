namespace PizzeriaPlace.Models
{
    public class CarritoCompras
    {
        public Clientes clientes { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pago { get; set; }
        public void Add(int PizzaId) => Pedidos.Add(PizzaId);
        public void RemoveAt(int PedidaId) => Pedidos.RemoveAt(PedidaId);
    }
}
