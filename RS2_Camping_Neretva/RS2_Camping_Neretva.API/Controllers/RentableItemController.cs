using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentableItemController : ControllerBase
    {
        protected IRentableItemService _service;

        public RentableItemController(IRentableItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<RentableItemModel> GetList()
        {
            return _service.GetList();
        }
    }
}
