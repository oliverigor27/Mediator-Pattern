namespace MediatorPattern.Core.Interface;

public interface IMediator
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
}
