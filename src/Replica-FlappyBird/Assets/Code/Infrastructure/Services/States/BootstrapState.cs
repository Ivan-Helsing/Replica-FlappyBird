using Code.Gameplay.Services;

namespace Code.Infrastructure.Services.States
{
  public class BootstrapState : IState
  {
    private readonly IArbiterService _arbiter;

    public BootstrapState(IArbiterService arbiter)
    {
      _arbiter = arbiter;
    }

    public void Enter()
    {
      _arbiter.LoadHighScore();
    }
  }
}