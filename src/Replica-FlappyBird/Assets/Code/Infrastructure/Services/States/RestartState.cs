using Code.Infrastructure.Services.Scenes;

namespace Code.Infrastructure.Services.States
{
  public class RestartState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly ISceneLoader _sceneLoader;

    public RestartState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
      _sceneLoader.LoadScene(Name.Initial, onLoaded: ProceedToNextState);
    }

    private void ProceedToNextState()
    {
      _stateMachine.Enter<BootstrapState>();
    }
  }
}