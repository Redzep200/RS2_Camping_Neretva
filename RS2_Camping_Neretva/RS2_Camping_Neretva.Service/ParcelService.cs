using RS2_Camping_Neretva.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public class ParcelService : IParcelService
    {
        public Task<ParcelModel> CreateAsync(ParcelModel parcel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ParcelModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ParcelModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ParcelModel> UpdateAsync(int id, ParcelModel parcel)
        {
            throw new NotImplementedException();
        }
    }
}
