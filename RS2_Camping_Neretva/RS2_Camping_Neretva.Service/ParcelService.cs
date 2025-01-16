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
        public List<ParcelModel> List = new List<ParcelModel>()
        {
            new ParcelModel() {
            parcelId = 1,
            parcelNumber = 1,
            description = "parcel on grass",
            electricity = true,
            shade = false
            },
            new ParcelModel() {
            parcelId = 2,
            parcelNumber = 2,
            description = "parcel on grass",
            electricity = true,
            shade = true
            }
        };
        public List<ParcelModel> GetList()
        {
            return List;
        }
    }
}
