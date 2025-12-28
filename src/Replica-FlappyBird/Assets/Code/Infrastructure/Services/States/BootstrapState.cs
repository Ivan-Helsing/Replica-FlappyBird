using Code.Gameplay.Services;
using Code.Infrastructure.Services.Scenes;

namespace Code.Infrastructure.Services.States
{
  public class BootstrapState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly IArbiterService _arbiter;
    private readonly ISceneLoader _sceneLoader;

    public BootstrapState(IGameStateMachine stateMachine, IArbiterService arbiter, ISceneLoader sceneLoader)
    {
      _stateMachine = stateMachine;
      _arbiter = arbiter;
      _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
      _arbiter.LoadHighScore();
      _sceneLoader.LoadScene(Name.Main, onLoaded: ProceedToNextState);
    }

    private void ProceedToNextState() => 
      _stateMachine.Enter<GameplayState>();
  }
}