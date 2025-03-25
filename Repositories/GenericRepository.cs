

namespace rentalApi.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        public virtual async Task<List<T>> GetAllVehicles()
        {
            return new List<T>();
        }

        public virtual async Task<T> GetVehicleById(Guid id)
        {
            return null;
        }


    }
}
