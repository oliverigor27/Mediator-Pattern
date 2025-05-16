using MediatorPattern.Application.Interface;

namespace MediatorPattern.Application.Concrete;

public class Mediator : IMediator
{
    private BaseClass baseClassOne;
    private BaseClass baseClassTwo;

    public BaseClass BaseClassOne { set { baseClassOne = value; } }
    public BaseClass BaseClassTwo { set { baseClassTwo = value; } }

    public void Notify<T, Y>(T eventer, Y value)
    {

        throw new NotImplementedException();
    }
}
