using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IPaymentService
    {
        Task<List<PaymentModel>> GetAllAsync();
        Task<PaymentModel> GetByIdAsync(int id);
        Task<PaymentModel> CreateAsync(PaymentModel payment);
        Task<PaymentModel> UpdateAsync(int id, PaymentModel payment);
        Task DeleteAsync(int id);
    }
}
