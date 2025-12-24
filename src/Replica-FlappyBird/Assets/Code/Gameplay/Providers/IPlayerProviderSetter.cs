using Code.Gameplay.Player;

namespace Code.Gameplay.Providers
{
  public interface IPlayerProviderSetter
  {
    void SetPlayerMovement(IPlayerMovement playerMovement);
  }
}