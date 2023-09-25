namespace PizzeriaPlace.Models
{
    public class Pizzas1
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public decimal Precio { get; }
        public p2 Picante { get; }
        public Pizzas1(int Id, string Nombre, string Descricpion,decimal Precio, p2 Picantes)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descricpion;
            this.Precio = Precio;
            this.Picante = Picantes;
        }
    }
}
