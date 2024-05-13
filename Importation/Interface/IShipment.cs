using Importation.Model;

namespace Importation.Interface
{
    public interface IShipmentRepository
    {
        ICollection<Shipment> GetShipments();
        ICollection<Shipment> GetShipmentsUnitsByID(int id);
    }
}
