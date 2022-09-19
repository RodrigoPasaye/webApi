using Microsoft.AspNetCore.Mvc;
using webApi.Services;

namespace webApi.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase {
        IHelloWorldService _helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService) {
            _helloWorldService = helloWorldService;
        }

        public IActionResult Get() {
            return Ok(_helloWorldService.GetHelloWorld());
        }
    }
}
