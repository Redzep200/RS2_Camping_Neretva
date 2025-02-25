using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccommodationController : ControllerBase
    {
        protected IAccommodationService _service;

        public AccommodationController(IAccommodationService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<AccommodationModel> GetList()
        {
            return _service.GetList();
        }
    }
}
