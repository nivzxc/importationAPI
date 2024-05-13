using Importation.Interface;
using Importation.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Importation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentRepository _shipmentRepository;
        public ShipmentController(IShipmentRepository shipmentRepository)
        {
                _shipmentRepository = shipmentRepository;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Shipment>))]
        public IActionResult GetShipments() 
        {
            var shipments = _shipmentRepository.GetShipments();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(shipments);
        }

        [HttpGet("{id}")]
        public IActionResult GetShipmentsByID(int id) 
        {
            var ShipmentandUnits = _shipmentRepository.GetShipmentsUnitsByID(id);
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ShipmentandUnits);

        }

        //// GET: api/<ShipmentController>
        //[HttpGet]        
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ShipmentController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ShipmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShipmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
