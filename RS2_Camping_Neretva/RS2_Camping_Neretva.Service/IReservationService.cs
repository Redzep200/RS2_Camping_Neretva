using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public interface IReservationService
    {
        Task<List<ReservationModel>> GetAllAsync();
        Task<ReservationModel> GetByIdAsync(int id);
        Task<ReservationModel> CreateAsync(ReservationModel reservation);
        Task<ReservationModel> UpdateAsync(int id, ReservationModel reservation);
        Task DeleteAsync(int id);
    }
}
