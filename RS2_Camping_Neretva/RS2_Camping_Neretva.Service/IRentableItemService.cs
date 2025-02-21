using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IRentableItemService
    {
        Task<List<RentableItemModel>> GetAllAsync();
        Task<RentableItemModel> GetByIdAsync(int id);
        Task<RentableItemModel> CreateAsync(RentableItemModel rentableItem);
        Task<RentableItemModel> UpdateAsync(int id, RentableItemModel rentableItem);
        Task DeleteAsync(int id);
    }
}
