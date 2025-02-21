using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    internal interface IWorkerService
    {
        Task<List<WorkerModel>> GetAllAsync();
        Task<WorkerModel> GetByIdAsync(int id);
        Task<WorkerModel> CreateAsync(WorkerModel worker);
        Task<WorkerModel> UpdateAsync(int id, WorkerModel worker);
        Task DeleteAsync(int id);
    }
}
