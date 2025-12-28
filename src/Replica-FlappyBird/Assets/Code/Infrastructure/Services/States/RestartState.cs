using Code.Gameplay.UI.Service;
using Code.Infrastructure.Services.Scenes;

namespace Code.Infrastructure.Services.States
{
  public class RestartState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly ISceneLoader _sceneLoader;
    private readonly IUIService _uiService;

    public RestartState(IGameStateMachine stateMachine, ISceneLoader sceneLoader, IUIService uiService)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
      _uiService = uiService;
    }

    public void Enter()
    {
      _uiService.RestartLoosingState();
      _sceneLoader.LoadScene(Name.Initial, onLoaded: ProceedToNextState);
    }

    private void ProceedToNextState()
    {
      _stateMachine.Enter<BootstrapState>();
    }
  }
}