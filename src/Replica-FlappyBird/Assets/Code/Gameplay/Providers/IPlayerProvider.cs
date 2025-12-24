using Code.Gameplay.Player;

namespace Code.Gameplay.Providers
{
  public interface IPlayerProvider
  {
    IPlayerMovement PlayerMovement { get; }
  }
}