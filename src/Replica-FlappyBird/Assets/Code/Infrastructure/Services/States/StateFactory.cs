using Zenject;

namespace Code.Infrastructure.Services.States
{
  public class StateFactory : IStateFactory
  {
    private readonly IInstantiator _instantiator;

    public StateFactory(IInstantiator instantiator)
    {
      _instantiator = instantiator;
    }

    public T Create<T>() where T : IState => 
      _instantiator.Instantiate<T>();

    public T Create<T>(params object[] args) where T : IState => 
      _instantiator.Instantiate<T>(args);
  }
}