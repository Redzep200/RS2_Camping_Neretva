using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IPersonService
    {
        Task<List<PersonModel>> GetAllAsync();
        Task<PersonModel> GetByIdAsync(int id);
        Task<PersonModel> CreateAsync(PersonModel person);
        Task<PersonModel> UpdateAsync(int id, PersonModel person);
        Task DeleteAsync(int id);
    }
}
