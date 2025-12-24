using Code.Gameplay.Movement;

namespace Code.Gameplay.Providers
{
  public interface IPlayerProviderSetter
  {
    void SetPlayerMovement(IPlayerMovement playerMovement);
  }
}