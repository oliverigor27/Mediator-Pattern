namespace MediatorPattern.Application.Interface;

public interface IMediator
{
    void Notify<T, Y>(T eventer, Y value);
}
