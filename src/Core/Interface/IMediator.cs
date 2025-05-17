namespace MediatorPattern.Application.Interface;

public interface IMediator
{
    Task<TResponse> HandleAsync<TResponse>(IRequest<TResponse> request);
}
