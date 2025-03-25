using Microsoft.AspNetCore.Mvc;
using rentalApi.Data;
using rentalApi.Models;

namespace rentalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Vehicles>> GetAllVehicles()
        {
            return Ok(VehiclesData.VehiclesList);
        }

        [HttpGet("{id}")]
        public ActionResult<Vehicles> GetVehiclesById(int id)
        {
            var vehicle = VehiclesData.VehiclesList.FirstOrDefault(v => v.rentalContract.id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }
         

    }
}