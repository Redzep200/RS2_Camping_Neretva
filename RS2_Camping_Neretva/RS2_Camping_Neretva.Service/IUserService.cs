using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(int id);
        Task<UserModel> CreateAsync(UserModel user);
        Task<UserModel> UpdateAsync(int id, UserModel user);
        Task DeleteAsync(int id);
    }
}
