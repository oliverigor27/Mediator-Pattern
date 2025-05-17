namespace MediatorPattern.Core.Interface;

public interface IRequestHandler<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
{
    Task<TResponse> HandleAsync(TRequest request);
}
