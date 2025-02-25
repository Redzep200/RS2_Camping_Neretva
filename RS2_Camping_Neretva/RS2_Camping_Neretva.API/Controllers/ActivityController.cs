using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        protected IActivityService _service;
        public ActivityController(IActivityService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<ActivityModel> GetList()
        {
            return _service.GetList();
        }
    }
}
