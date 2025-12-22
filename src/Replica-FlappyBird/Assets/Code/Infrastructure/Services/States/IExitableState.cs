namespace Code.Infrastructure.Services.States
{
  public interface IExitableState : IState
  {
    void Exit();
  }
}