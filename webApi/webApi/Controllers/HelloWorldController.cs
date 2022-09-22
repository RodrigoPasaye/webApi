using Microsoft.AspNetCore.Mvc;
using webApi.Services;

namespace webApi.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase {
        IHelloWorldService _helloWorldService;

        TareasContext _context;

        public HelloWorldController(IHelloWorldService helloWorldService, TareasContext context) {
            _helloWorldService = helloWorldService;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_helloWorldService.GetHelloWorld());
        }

        [HttpGet]
        [Route("createDB")]
        public IActionResult CreateDatabase() {
            _context.Database.EnsureCreated();
            return Ok();
        }
    }
}
