using rentalApi.Models;

namespace rentalApi.Services
{
    public interface IVehiclesService
    {
        Task<List<Vehicles>> GetAllVehicles();

        Task<Vehicles> GetVehicleById(Guid id);
    }
}
