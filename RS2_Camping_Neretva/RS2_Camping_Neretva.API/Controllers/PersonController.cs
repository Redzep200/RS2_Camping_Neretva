using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        protected IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<PersonModel> GetList()
        {
            return _service.GetList();
        }
    }
}
