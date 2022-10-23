using MediatR;

namespace Application.HelloWorld;

public class HelloWorldQueryHandler : IRequestHandler<HelloWorldRequest, HelloWorldResponse>
{
    public async Task<HelloWorldResponse> Handle(HelloWorldRequest request, CancellationToken cancellationToken)
    {
        return new HelloWorldResponse { Response = $"response: {request.SomeParam}" };
    }
}
