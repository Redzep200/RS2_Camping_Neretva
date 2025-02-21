using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IAccommodationService
    {
        Task<List<AccommodationModel>> GetAllAsync();
        Task<AccommodationModel> GetByIdAsync(int id);
        Task<AccommodationModel> CreateAsync(AccommodationModel accommodation);
        Task<AccommodationModel> UpdateAsync(int id, AccommodationModel person);
        Task DeleteAsync(int id);
    }
}
