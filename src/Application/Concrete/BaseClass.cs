using MediatorPattern.Application.Interface;

namespace MediatorPattern.Application.Concrete;

public abstract class BaseClass(IMediator mediator)
{
    protected IMediator _mediator = mediator;

    public abstract void SendMessage(string message);
    public abstract void GetMessage(string message);
}
