using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public class RentableItemService : IRentableItemService
    {
        public CampingNeretvaRs2Context _context { get; set; }
        public IMapper Mapper { get; set; }

        public RentableItemService(CampingNeretvaRs2Context context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }

        public List<RentableItemModel> GetList()
        {
            List<RentableItemModel> result = new List<RentableItemModel>();

            var list = _context.RentableItems.ToList();
            result = Mapper.Map(list, result);
            return result;
        }
    }
}
