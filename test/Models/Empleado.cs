using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Empleado
    {
        [Key]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
    }
}
