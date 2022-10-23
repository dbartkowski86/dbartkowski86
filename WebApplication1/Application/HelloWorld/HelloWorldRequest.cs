using MediatR;

namespace Application.HelloWorld;

public class HelloWorldRequest: IRequest<HelloWorldResponse>
{
    public string? SomeParam { get; set; }
}
