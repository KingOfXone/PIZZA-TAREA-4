using System.ComponentModel.DataAnnotations;

namespace PizzeriaPlace.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; } 

        [Required(ErrorMessage = "Proporcione su nombre")]
        public string Nombre { get; set; } = default!;
       
        [Required(ErrorMessage = "Necesitamos saber su opinion")]
        public string Servicio { get; set; } = default!;
    }
}
