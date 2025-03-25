using rentalApi.Models;
using rentalApi.Repositories;
namespace rentalApi.Services
{
    public class VehiclesService : IVehiclesService
    {
        private readonly IRepository<Vehicles> _vehicleRepository;

        public VehiclesService(IRepository<Vehicles> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<List<Vehicles>> GetAllVehicles()
        {
            return await _vehicleRepository.GetAllVehicles();
        }

        public async Task<Vehicles> GetVehicleById(Guid id)
        {
            return await _vehicleRepository.GetVehicleById(id);
        }
    }
}

