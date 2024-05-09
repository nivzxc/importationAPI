using System.ComponentModel.DataAnnotations;

namespace Importation.Model
{
    public class Unit
    {

        [Key]
        [Required]        
        public int UnitId { get; set; }

        [Required]
        [MaxLength(20)]
        public string UnitNo { get; set; }

        [Required]
        [MaxLength(30)]
        public string EngineNo { get; set; }

        [Required]
        [MaxLength(10)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string ChassisNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Series { get; set; }

        [Required]
        [MaxLength(50)]
        public string BodyType { get; set; }

        [Required]
        [MaxLength(10)]
        public int Year { get; set; }

        [Required]
        [MaxLength(10)]
        public string Color { get; set; }

        public Shipment shipmentId { get; set; }

    }
}
