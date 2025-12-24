using Code.Gameplay.Player;

namespace Code.Gameplay.Providers
{
  public class PlayerProvider : IPlayerProvider, IPlayerProviderSetter
  {
    private IPlayerMovement _playerMovement;
    public IPlayerMovement PlayerMovement => _playerMovement;

    public void SetPlayerMovement(IPlayerMovement playerMovement) => 
      _playerMovement = playerMovement;
  }
}