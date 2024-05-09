using System.ComponentModel.DataAnnotations;

namespace Importation.Model
{
    public class Shipment
    {
        [Key]
        [Required]
        public int shipmentid { get; set; }

        [Required]
        [MaxLength (70)]
        public string shipmentNo { get; set; }

        [Required]
        [MaxLength (30)]
        public string SupplierID { get; set; }
        [Required]
        [MaxLength (50)]
        public string ContainerNo { get; set; }

        [Required]
        public DateTime ShipmentDate { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }
        public ICollection<Unit> Units { get; set; }
    }
}
