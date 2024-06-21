using FrontOffice.Database;
using Microsoft.AspNetCore.Mvc;

namespace FrontOffice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly DataAccess _dataAccess;

        public JobsController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var jobs = _dataAccess.GetJobs();
            return Ok(jobs);
        }
    }
}
