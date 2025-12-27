using Code.Gameplay.Road;
using Code.Gameplay.UI.Windows;
using UnityEngine;

namespace Code.Infrastructure.Services.AssetsManagement
{
  public class AssetsProvider : IAssetsProvider
  {
    public Segment LoadSegment()
    {
      return Resources.Load<Segment>(AssetPath.Segment);
    }

    public LoosingWindow LoadLoosingWindow() => 
      Resources.Load<LoosingWindow>(AssetPath.LoosingWindow);
  }
}