using Microsoft.AspNetCore.Mvc;
using RS2_Camping_Neretva.Model;
using RS2_Camping_Neretva.Service;

namespace RS2_Camping_Neretva.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        protected IWorkerService _service;
        public WorkerController(IWorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<WorkerModel> GetList()
        {
            return _service.GetList();
        }
    }
}
