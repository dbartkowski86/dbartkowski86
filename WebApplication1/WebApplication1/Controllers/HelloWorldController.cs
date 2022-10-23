using Application.HelloWorld;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;
    private ISender _mediator;

    public HelloWorldController(ILogger<HelloWorldController> logger, ISender mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "hello")]

    public async Task<HelloWorldResponse> Get(
        [FromQuery] string someParam)
    {
        var req = new HelloWorldRequest { SomeParam = someParam };
        return await _mediator.Send(req);

    }
}