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
    public class ActivityService : IActivityService
    {
        public CampingNeretvaRs2Context _context { get; set; }
        public IMapper Mapper { get; set; }

        public ActivityService(CampingNeretvaRs2Context context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }

        public List<ActivityModel> GetList()
        {
            List<ActivityModel> result = new List<ActivityModel>();

            var list = _context.Activities
                .Include(a => a.Facility)
                .ToList();

            result = Mapper.Map(list, result);

            for (int i = 0; i < result.Count; i++)
            {
                result[i].FacilityType = list[i].Facility?.FacilityType;
            }

            return result;
        }
    }
}
