using Code.Gameplay.Movement;

namespace Code.Gameplay.Providers
{
  public class PlayerProvider : IPlayerProvider, IPlayerProviderSetter
  {
    private IPlayerMovement _playerMovement;
    public IPlayerMovement Movement => _playerMovement;

    public void SetPlayerMovement(IPlayerMovement playerMovement) => 
      _playerMovement = playerMovement;
  }
}