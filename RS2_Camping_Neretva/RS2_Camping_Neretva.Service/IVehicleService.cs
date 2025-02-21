using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IVehicleService
    {
        Task<List<VehicleModel>> GetAllAsync();
        Task<VehicleModel> GetByIdAsync(int id);
        Task<VehicleModel> CreateAsync(VehicleModel vehicle);
        Task<VehicleModel> UpdateAsync(int id, VehicleModel vehicle);
        Task DeleteAsync(int id);
    }
}
