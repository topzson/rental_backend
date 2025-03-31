using Microsoft.AspNetCore.Mvc;
using rentalApi.Data;
using rentalApi.Models;
using rentalApi.Services;

namespace rentalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehiclesService _vehiclesService;
        public VehiclesController(IVehiclesService vehiclesService)
        {
            _vehiclesService = vehiclesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVehicles()
        {
            var vehicles = await _vehiclesService.GetAllVehicles();
            if (vehicles == null || !vehicles.Any())
            {
                return NotFound();
            }
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleById(Guid id)
        {
            var vehicle = await _vehiclesService.GetVehicleById(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }
    }
}