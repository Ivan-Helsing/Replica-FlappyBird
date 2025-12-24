using Code.Gameplay.Movement;

namespace Code.Gameplay.Providers
{
  public interface IPlayerProvider
  {
    IPlayerMovement Movement { get; }
  }
}