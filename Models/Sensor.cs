using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLaboratorial.Models
{
    public class Sensor
    {
        [Key]
        [Column(TypeName = "uuid")] 
        public Guid Id { get; set; }
        public string Dispositivo { get; set; }
        public double Temperatura { get; set; }
        public double Bateria { get; set; }
        
    }
}
