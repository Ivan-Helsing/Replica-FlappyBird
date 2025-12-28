namespace Code.Infrastructure.Services.States
{
  public class GameplayState : IState
  {
    private readonly IGameStateMachine _stateMachine;

    public GameplayState(IGameStateMachine stateMachine) => 
      _stateMachine = stateMachine;

    public void Enter()
    {
    }

    public void MoveToRestartState() => 
      _stateMachine.Enter<RestartState>();
  }
}