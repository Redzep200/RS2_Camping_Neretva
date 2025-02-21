using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IParcelService
    {
        Task<List<ParcelModel>> GetAllAsync();
        Task<ParcelModel> GetByIdAsync(int id);
        Task<ParcelModel> CreateAsync(ParcelModel parcel);
        Task<ParcelModel> UpdateAsync(int id, ParcelModel parcel);
        Task DeleteAsync(int id);
    }
}
