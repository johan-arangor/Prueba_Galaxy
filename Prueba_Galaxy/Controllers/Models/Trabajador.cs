using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba_Galaxy.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        [Required]
        public int IdTypeDocument { get; set; }
        public String PNombre { get; set; }
        public String SNombre{ get; set; }
        public String PApellido { get; set; }
        public String SApellido { get; set; }
        public DateTime FNacimiento { get; set; }
    }
}
