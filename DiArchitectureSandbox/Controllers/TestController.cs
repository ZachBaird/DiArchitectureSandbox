using DiArchitectureSandbox.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiArchitectureSandbox.Controllers;

[ApiController]
[Route("/test/")]
public class TestController : ControllerBase
{
    private readonly HelloService _helloService;
    private readonly GoodbyeService _goodbye;

    public TestController(HelloService helloService, GoodbyeService goodbye)
    {
        _helloService = helloService;
        _goodbye = goodbye;
    }

    [HttpGet]
    [Route("index")]
    public IActionResult Index() => Ok("Successful hit");

    [HttpGet]
    [Route("hello")]
    public IActionResult Hello([FromQuery] string name) => Ok(_helloService.SayHello(name));

    [HttpGet]
    [Route("goodbye")]
    public IActionResult Goodbye() => Ok(_goodbye.SayGoodbye());
}
