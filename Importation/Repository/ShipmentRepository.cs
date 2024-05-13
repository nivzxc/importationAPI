using Importation.Data;
using Importation.Interface;
using Importation.Model;
using Microsoft.EntityFrameworkCore;

namespace Importation.Repository
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly DataContext _context;
        public ShipmentRepository(DataContext context) 
        {        
            _context = context;
        }

        public ICollection<Shipment> GetShipments()
        {
            return _context.Shipments.OrderBy(p => p.shipmentid).ToList();        
        }

        public ICollection<Shipment> GetShipmentsUnitsByID(int id) 
        {
            return _context.Shipments.Where(sid => sid.shipmentid == id).Include(u=>u.Units).ToList();
        
        }
    }
}
