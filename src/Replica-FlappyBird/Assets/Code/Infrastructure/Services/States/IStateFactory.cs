namespace Code.Infrastructure.Services.States
{
  public interface IStateFactory
  {
    T Create<T>() where T : IState;
    T Create<T>(params object[] args) where T : IState;
  }
}