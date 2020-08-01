using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba_Galaxy.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        [Required]
        public int NumContrato { get; set; }
        public int IdTrabajador { get; set; }
        public String IdEntidad { get; set; }
        public DateTime Finicio{ get; set; }
        public DateTime FFin { get; set; }
    }
}
