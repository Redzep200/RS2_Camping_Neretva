using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IFacilityService
    {
        Task<List<FacilityModel>> GetAllAsync();
        Task<FacilityModel> GetByIdAsync(int id);
        Task<FacilityModel> CreateAsync(FacilityModel facility);
        Task<FacilityModel> UpdateAsync(int id, FacilityModel facility);
        Task DeleteAsync(int id);
    }
}
