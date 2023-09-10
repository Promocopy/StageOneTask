using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StageOneTask.Data;
using StageOneTask.Entity;
using StageOneTask.Interface;

namespace StageOneTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SOTController : ControllerBase
    {
        private readonly ISOTinterface _interface;

        public SOTController(ISOTinterface @interface)
        {
            _interface=@interface;
        }

        [HttpGet("Name")]
        public IActionResult GetNmae(string SlackName)
        {
            var user = _interface.GetName(SlackName);
            return Ok(user);
        }

        [HttpGet("Track")]
        public IActionResult GetTrack(string Track)
        {
           var user = _interface.GetTrack(Track);
            return Ok(user);
        }

        [HttpPost("AddUser")]
        public IActionResult AddTask(SOT task)
        {
           var user = _interface.AddTask(task);
            return Ok(user);

        }
    }
}
