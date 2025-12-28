using System;
using System.Collections.Generic;

namespace Code.Infrastructure.Services.States
{
  public class GameStateMachine : IGameStateMachine, IRestartStateLauncher
  {
    private readonly Dictionary<Type, IState> _states = new();
    private IExitableState _activeState;
    
    public GameStateMachine(IStateFactory stateFactory)
    {
      _states.Add(typeof(BootstrapState), stateFactory.Create<BootstrapState>(this));
      _states.Add(typeof(GameplayState), stateFactory.Create<GameplayState>());
      _states.Add(typeof(RestartState), stateFactory.Create<RestartState>(this));
    }

    public void MoveToRestartState() => 
      Enter<RestartState>();
    
    public void Enter<TState>() where TState : class, IState
    {
      _activeState?.Exit();
      IState state = GetState<TState>();
      SetActiveState(state);
      state.Enter();
    }

    private IState GetState<TState>() where TState : class, IState => 
      _states[typeof(TState)];

    private void SetActiveState(IState state)
    {
      if(state is IExitableState exitableState)
        _activeState = exitableState;
    }
  }
}