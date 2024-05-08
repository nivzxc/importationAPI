namespace Importation.Model
{
    public class Shipment
    {
        public string shipmentID { get; set; }
        public string SupplierID { get; set; }
        public string ContainerNo { get; set; }
        public ICollection<Unit> Units { get; set; }
        public DateTime ShipmentDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
