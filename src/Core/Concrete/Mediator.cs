using MediatorPattern.Application.Interface;

namespace MediatorPattern.Application.Concrete;

public class Mediator(
    IServiceProvider serviceProvider
) : IMediator
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;

    public async Task<TResponse> HandleAsync<TResponse>(IRequest<TResponse> request)
    {
        var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
        var handler = _serviceProvider.GetService(handlerType) 
            ?? throw new InvalidOperationException($"Handler not found for{request.GetType().Name}");

        var method = handlerType.GetMethod("HandleAsync");

        var task = (Task<TResponse>)method!.Invoke(handler, [request])!;
        return await task;
    }
}
