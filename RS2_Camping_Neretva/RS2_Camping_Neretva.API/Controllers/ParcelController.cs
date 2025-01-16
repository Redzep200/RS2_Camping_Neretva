using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParcelController : ControllerBase
    {
        protected IParcelService _service;

        public ParcelController(ParcelService service)
        {
            _service = service;
        }

        [HttpGet]
       public List<ParcelModel> getList()
        {
            return _service.GetList();
        }
    }
}
