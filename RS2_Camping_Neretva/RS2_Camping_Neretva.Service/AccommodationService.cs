using MapsterMapper;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service
{
    public class AccommodationService : IAccommodationService
    {
        public CampingNeretvaRs2Context _context { get; set; }
        public IMapper Mapper { get; set; }

        public AccommodationService(CampingNeretvaRs2Context context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }

        public List<AccommodationModel> GetList()
        {
            List<AccommodationModel> result = new List<AccommodationModel>();

            var list = _context.Accommodations.ToList();
            result = Mapper.Map(list, result);
            return result;
        }
    }
}
