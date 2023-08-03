using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Maquinaria
    {
        [Key]
        public string Serie { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
