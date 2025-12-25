using Code.Gameplay.Road;

namespace Code.Infrastructure.Services.AssetsManagement
{
  public interface IAssetsProvider
  {
    Segment LoadSegment();
  }
}