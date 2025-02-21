using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IReviewService
    {
        Task<List<ReviewModel>> GetAllAsync();
        Task<ReviewModel> GetByIdAsync(int id);
        Task<ReviewModel> CreateAsync(ReviewModel review);
        Task<ReviewModel> UpdateAsync(int id, ReviewModel review);
        Task DeleteAsync(int id);
    }
}
