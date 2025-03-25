using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rentalApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllVehicles();
        Task<T> GetVehicleById(Guid id);

    }
}
