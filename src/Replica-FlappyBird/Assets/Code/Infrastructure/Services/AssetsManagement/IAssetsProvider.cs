using Code.Gameplay.Road;
using Code.Gameplay.UI.Windows;

namespace Code.Infrastructure.Services.AssetsManagement
{
  public interface IAssetsProvider
  {
    Segment LoadSegment();
    LoosingWindow LoadLoosingWindow();
  }
}