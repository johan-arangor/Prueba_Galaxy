using System.ComponentModel.DataAnnotations;

namespace Prueba_Galaxy.Controllers.Models
{
    public class Entidad
    {
        public int Id { get; set; }
        [Required]
        public int Nombre { get; set; }
    }
}
