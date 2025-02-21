using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IActivityService
    {
        Task<List<ActivityModel>> GetAllAsync();
        Task<ActivityModel> GetByIdAsync(int id);
        Task<ActivityModel> CreateAsync(ActivityModel activity);
        Task<ActivityModel> UpdateAsync(int id, ActivityModel activity);
        Task DeleteAsync(int id);
    }
}
